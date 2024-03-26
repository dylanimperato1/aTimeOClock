using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


// HEX CODE FOR GREEN COLOR: 5AEC7F


public class Overworld_2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI xpText;
    float displayXPTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        xpText.alpha = 0;
    }

    public void GainXP(int amount)
    {
        // color of grass = gray color + (diff between healthy color and grey color * (amount/1000))
        PublicVars.xp += amount;

        PublicVars.gained_xp = true;

        xpText.text = "+" + amount.ToString() + " XP";
    }

    // Update is called once per frame
    void Update()
    {
        if (PublicVars.gained_xp)
        {
            xpText.alpha = 1;

            displayXPTime -= Time.deltaTime;

            if (displayXPTime <= 0)
            {
                displayXPTime = 1f;
                xpText.alpha = 0;
                PublicVars.gained_xp = false;
            }

        }
    }
}
