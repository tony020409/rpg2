using UnityEngine;
using System.Collections;

public class FunctionBar : MonoBehaviour {

    public void OnStatusButtonClick() {
        Status._instance.TransformState();
    }
    public void OnBagButtonClick() {
        Inventory._instance.TransformState();
    }
    public void OnEquipButtonClick() {
    }
    public void OnSkillButtonClick() {
    }
    public void OnSettingButtonClick() {
    }


}
