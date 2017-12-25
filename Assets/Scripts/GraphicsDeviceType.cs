using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsDeviceType : MonoBehaviour {
    public Text infoText;

	void Start () {
        infoText.text = SystemInfo.graphicsDeviceType.ToString();
	}
}
