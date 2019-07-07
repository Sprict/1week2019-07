using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Panel", menuName = "CreatePanel")]
public class Panel : ScriptableObject
{

	//　パネルのイメージ
	[SerializeField]
	private Sprite image;

	[SerializeField]
	private string panelName;
	//　所要時間
	[SerializeField]
	private int requiredTime;
	//　手に入る素材リスト
	[SerializeField]
	private List<Item> itemLists = new List<Item>();
	[SerializeField]
	private List<int> maxItemValue = new List<int>();
	private Dictionary<Item, int> maxOfItem = new Dictionary<Item, int>();

	public Panel()
	{
		for (int i = 0; i < itemLists.Count; i++)
		{
			//　アイテム数を適当に設定
			maxOfItem.Add(itemLists[i], maxItemValue[i]);
		}
	}
	public Sprite GetImage()
	{
		return image;
	}

	public string GetPanelName()
	{
		return panelName;
	}

	public int GetRequiredTime()
	{
		return requiredTime;
	}
	//　アイテムリストを返す
	public List<Item> GetItemLists()
	{
		return itemLists;
	}

	public Dictionary<Item, int> GetMaxOfItem()
	{
		return maxOfItem;
	}

	public void AddMaxOfItem(Item item, int i)
	{
		maxOfItem[item] += i;
	}

	public void SubMaxOfItem(Item item, int i)
	{
		maxOfItem[item] -= i;
	}

}