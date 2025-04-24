using UnityEngine;

public class EnemyParticle : MonoBehaviour
{
    private ParticleSystem part;
    private ParticleSystem.Particle[] particles;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        // Перевіряємо, чи це ворог
        //Enemy enemy = other.GetComponent<Enemy>();
        //if (enemy != null)
        //{
        //    enemy.TakeDamage(10); // Викликаємо метод у ворога
        //}

        Debug.Log("COlision" + other.name); ///////////////////////
    }
}