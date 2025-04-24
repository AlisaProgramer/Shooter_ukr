using Photon.Pun;
using UnityEngine;

public class RayCastTest : MonoBehaviourPun
{
    public LayerMask mask;
    public float distance = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && photonView.IsMine) // тільки свій гравець виконує рейкаст
        {
            CastRay();
        }

        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);
    }

    void CastRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, distance, mask))
        {
            if (hit.collider.gameObject.TryGetComponent<HealthSystem>(out HealthSystem healthSys))
            {
                // Відправляємо інформацію про попадання іншим клієнтам
                photonView.RPC("ApplyDamage", RpcTarget.All, hit.collider.gameObject.GetComponent<PhotonView>().ViewID, 20);
            }
        }
    }

    [PunRPC]
    void ApplyDamage(int targetViewID, int damage)
    {
        PhotonView targetPhotonView = PhotonView.Find(targetViewID);
        if (targetPhotonView != null && targetPhotonView.TryGetComponent<HealthSystem>(out HealthSystem healthSys))
        {
            healthSys.GetDamage(damage);
        }
    }
}