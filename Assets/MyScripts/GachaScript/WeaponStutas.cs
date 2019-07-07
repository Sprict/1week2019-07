using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStutas : MonoBehaviour
{
    public int Rank = 1;
    public Sprite[] rankImage;


    public void RankSet(int rank)
    {
        Rank = rank;
        this.GetComponent<SpriteRenderer>().sprite = rankImage[Rank];
    }
}
