using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoverSmoke : MonoBehaviour
{
    public BattleSystem bs;
    public Unit pu;
    public Unit eu;

    public void OnMouseOver()
    {
        bs.DialogueText.text = "Raises: Enemy's DEF. by " + bs.SmokeAmount + "\n Lowers: Enemy's SPEED by " + bs.SmokeAmount;
    }

    public void OnMouseExit()
    {
        bs.DialogueText.text = "What Move Will You Choose?";
    }
}
