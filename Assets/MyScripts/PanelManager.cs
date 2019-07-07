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

	private Panel selectedPanel;
	private List<Item> itemList;
	// Use this for initialization
	void Start()
	{
		selectedPanel = GetRandomPanel();
		Image[] image = GetComponentsInChildren<Image>();
		Text targettext = GetComponentInChildren<Text>();
		image[1].sprite = selectedPanel.GetImage();
		itemList = selectedPanel.GetItemLists();
		int requiredTime = selectedPanel.GetRequiredTime();

		targettext.text = "所要時間：\n\t" + requiredTime + "年"
						+ "\n手に入るアイテム：";
		// 手に入るアイテムリストをテキストに加える
		itemList.ForEach(item =>
		{
			targettext.text += "\n\t" + item.GetItemName();
		});

	}

	//　名前でパネルを取得
	public Panel GetPanel(string searchName)
	{
		return PanelDataBase.GetPanelLists().Find(PanelName => PanelName.GetPanelName() == searchName);
	}

	// PanelDataBaseからランダムなPanelを返す
	public Panel GetRandomPanel()
	{
		// Debug.Log(PanelDataBase.GetPanelLists()[0]);
		int random = Random.Range(0, PanelDataBase.GetPanelLists().Count);
		Panel selectedPanel = PanelDataBase.GetPanelLists()[random];
		selectedPanel.Initialize();
		return selectedPanel;
	}

	public void RandomAddMaxOfItem()
	{
		foreach (Item Key in selectedPanel.GetMaxOfItem().Keys)
		{
			Debug.Log(Key);
		}
		foreach (Item item in itemList)
		{
			int gotItemNum = Random.Range(0, selectedPanel.GetMaxOfItem()[item]);
			selectedPanel.AddMaxOfItem(item, gotItemNum);
			Debug.Log(selectedPanel.GetMaxOfItem()[item]);
		}
	}
}