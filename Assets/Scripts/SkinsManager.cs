using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinsManager : MonoBehaviour
{
    public Image knife,gun,awp,terorist,contterorist,pistol;
    public Sprite [] knifes, guns, awps, terorists, contterorists, pistols;
    public int knifein, gunin, awpin, teroristin, contteroristin, pistolin;
    public Button knifebut, gunbut, awpbut, teroristbut, contteroristbut, pistolbut;
    // Start is called before the first frame update
    void Start()
    {
        knifebut.onClick.AddListener(ChangeKnife);
        gunbut.onClick.AddListener(ChangeGun);
        awpbut.onClick.AddListener(ChangeAwp);
        teroristbut.onClick.AddListener(ChangeTerorist);
        contteroristbut.onClick.AddListener(ChangeContrTerorist);
        pistolbut.onClick.AddListener(ChangePistol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeKnife()
    {
        knife.sprite = knifes[knifein];
        knifein++;
        if(knifein == knifes.Length)
        {
            knifein = 0;
        }
    }
    public void ChangeGun()
    {
        gun.sprite = guns[gunin];
        gunin++;
        if (gunin == guns.Length)
        {
            gunin = 0;
        }
    }
    public void ChangeAwp()
    {
        awp.sprite = awps[awpin];
        awpin++;
        if (awpin == awps.Length)
        {
            awpin = 0;
        }
    }
    public void ChangeContrTerorist()
    {
        contterorist.sprite = contterorists[contteroristin];
        contteroristin++;
        if (contteroristin == contterorists.Length)
        {
            contteroristin = 0;
        }
    }
    public void ChangeTerorist()
    {
        terorist.sprite = terorists[teroristin];
        teroristin++;
        if (teroristin == terorists.Length)
        {
            teroristin = 0;
        }
    }
    public void ChangePistol()
    {
        pistol.sprite = pistols[pistolin];
        pistolin++;
        if (pistolin == pistols.Length)
        {
            pistolin = 0;
        }
    }
}
