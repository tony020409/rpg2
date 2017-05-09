using UnityEngine;
using System.Collections;

public class InventoryDes : MonoBehaviour {

    public static InventoryDes _instance;
    private UILabel label;
    private float timer = 0;

    void Awake() {
        _instance = this;
        label = this.GetComponentInChildren<UILabel>();
        this.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.activeInHierarchy == true) {
            timer -= Time.deltaTime;
            if (timer <= 0) {
                this.gameObject.SetActive(false);
            }
        }
	}

    public void Show(int id) {
        this.gameObject.SetActive(true); timer = 0.1f;
        transform.position = UICamera.currentCamera.ScreenToWorldPoint(Input.mousePosition);
        ObjectInfo info = ObjectsInfo._instance.GetObjectInfoById(id);
        string des = "";
        switch (info.type) {
            case ObjectType.Drug:
                des = GetDrugDes(info);
                break;
        }
        label.text = des;
    }


    string GetDrugDes(ObjectInfo info) {
        string str = "";
        str += "名称：" + info.name + "\n";
        str += "+HP : " + info.hp + "\n";
        str += "+MP：" + info.mp + "\n";
        str += "出售价：" + info.price_sell + "\n";
        str += "购买价：" + info.price_buy;

        return str;
    }
}
