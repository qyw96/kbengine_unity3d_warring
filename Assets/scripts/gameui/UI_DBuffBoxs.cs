using UnityEngine;
using KBEngine;
using System; 

public class UI_DBuffBoxs : MonoBehaviour {
	UnityEngine.GameObject[] sys_itemslotbds = new UnityEngine.GameObject[20];
	
	void Awake ()     
	{
		for(int i=0; i<20; i++)
		{
			sys_itemslotbds[i] = UnityEngine.GameObject.Find("sys_itemslotbd" + (i + 1));
			NGUITools.SetActive(sys_itemslotbds[i], false);
		}
	}
	
	// Use this for initialization
	void Start () {
	}

	void Update()
	{
	}
}
 