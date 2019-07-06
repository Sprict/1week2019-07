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
	//　所得できる素材リスト
	private List<Item> itemLists = new List<Item>();

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
}