using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverHeal : MonoBehaviour
{
    public BattleSystem bs;
    public Unit pu;


    public void OnMouseOver()
    {

        bs.DialogueText.text = "Raises: Your HP by " + bs.HealAmount;
    }

    public void OnMouseExit()
    {
        bs.DialogueText.text = "What Move Will You Choose?";
    }
}
