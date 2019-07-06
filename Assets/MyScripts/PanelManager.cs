using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{

	//　アイテムデータベース
	[SerializeField]
	private PanelDataBase PanelDataBase;
	//　アイテム数管理
	private Dictionary<Panel, int> numOfPanel = new Dictionary<Panel, int>();

	// Use this for initialization
	void Start()
	{
		int r = Random.Range(0, PanelDataBase.GetPanelLists().Count);

		string name = PanelDataBase.GetPanelLists()[0].GetPanelName();

	}

	//　名前でアイテムを取得
	public Panel GetPanel(string searchName)
	{
		return PanelDataBase.GetPanelLists().Find(PanelName => PanelName.GetPanelName() == searchName);
	}
}