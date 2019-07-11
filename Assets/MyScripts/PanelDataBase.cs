using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PanelDataBase", menuName = "CreatePanelDataBase")]
public class PanelDataBase : ScriptableObject
{

	[SerializeField]
	private List<Panel> panelLists = new List<Panel>();

	//　アイテムリストを返す
	public List<Panel> GetPanelLists()
	{
		return panelLists;
	}
}