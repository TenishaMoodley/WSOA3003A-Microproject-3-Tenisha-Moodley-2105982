using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverAtk : MonoBehaviour
{

    public BattleSystem bs;
    public Unit pu;


    public void OnMouseOver() 
    {
        
        bs.DialogueText.text = "Lowers: Enemy's HP by " + pu.Damage;
    }

    public void OnMouseExit()
    {
        bs.DialogueText.text = "What Move Will You Choose?";
    }

}
