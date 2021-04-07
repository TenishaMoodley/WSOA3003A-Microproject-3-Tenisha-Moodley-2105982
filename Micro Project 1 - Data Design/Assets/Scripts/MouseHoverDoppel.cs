using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverDoppel : MonoBehaviour
{
    public BattleSystem bs;
    public Unit pu;
    public Unit eu;


    public void OnMouseOver()
    {
        bs.DialogueText.text = "Raises: Enemy's Attack Damage by " + bs.DoppelAmount + "\n Lowers: Enemy's ACC by " + bs.DoppelAmount;
    }

    public void OnMouseExit()
    {
        bs.DialogueText.text = "What Move Will You Choose?";
    }
}
