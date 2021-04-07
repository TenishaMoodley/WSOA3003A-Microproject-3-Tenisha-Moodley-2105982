using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
    public TMP_Text NameText;
    public TMP_Text LevelText;
    public Slider HPSlider;
    public TMP_Text StatsText;

    public void SetHUD(Unit unit)
    {
        NameText.text = unit.UnitName;
        LevelText.text = "LVL. " + unit.UnitLevel;
        HPSlider.maxValue = unit.MaxHP;
        HPSlider.value = unit.CurrentHP;
        StatsText.text = "Accuracy: " + unit.CurrentAcc + "%" + "\n" + "Speed: " + unit.CurrentSpeed;

    }

    public void SetHP(int hp)
    {
        HPSlider.value = hp;
    }
}
