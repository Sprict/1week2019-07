using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StutasUpHello : MonoBehaviour
{
    public int drowGachaRemaing = 5;
    public WeaponStutas weapon;

    private int helloStutas = 0;
    private int weaponStar = 0;
    private int probabilityRandamRange = 100;
    private int[] test = { 5 };
    private int numberReiforcements = 0;
    private float[] starIndication = { 0.5f, 0.7f, 0.85f, 0.95f};

    void Start()
    {
        weaponStar = 1;


        int weaponRank = RankEmissionRate(test);
        int stetas = StutasUP(weaponRank, numberReiforcements);
        
    }

    // 勇者に加算するステータスを決める
    private int StutasUP(int star=1, int possessionItem=0)
    {
        float helloStutasRsingValue = 0;

        float stutasUpMin = Mathf.Pow((star + 1), 2);
        float stutasUpMax = Mathf.Pow( (star + 1), 3 );

        helloStutasRsingValue = Random.Range(stutasUpMin, stutasUpMax);
        helloStutasRsingValue += 10 * star;
        helloStutasRsingValue *= 1 + (possessionItem * 0.1f);

        //Debug.Log((int)helloStutasRsingValue);
        return (int)helloStutasRsingValue;
    }

    // ランクを決める
    private int RankEmissionRate(int[] weaponRank)
    {
        float weaponRankAverage = 0;
        float probability = 0;
        int starRank = 0;


        // 入れた素材のランクの平均
        for (int i=0; i<weaponRank.Length; i++)
        {
            weaponRankAverage += (float)weaponRank[i];
        }
        weaponRankAverage /= weaponRank.Length;

        probability = Random.Range(0, probabilityRandamRange - weaponRankAverage * probabilityRandamRange * 0.1f) / probabilityRandamRange;
        probability += weaponRankAverage * 0.1f;


        // レア度の決定
        if (probability < starIndication[0])
        {
            starRank = 1;
        }
        else if (probability > starIndication[0] && probability < starIndication[1])
        {
            starRank = 2;
        }
        else if (probability > starIndication[1] && probability < starIndication[2])
        {
            starRank = 3;
        }
        else if (probability > starIndication[2] && probability < starIndication[3])
        {
            starRank = 4;
        }
        else if (probability > starIndication[3])
        {
            starRank = 5;
        }

        // 決まったランクを返す
        return starRank;
    }


    // ガチャを引いた時に呼ぶ関数
    public void GachaOn()
    {
        // ガチャが引ける回数
        if (drowGachaRemaing > 0)
        {
            test[0] = Random.Range(1, 5);
            int weaponRank = RankEmissionRate(test);
            helloStutas += StutasUP(weaponRank, numberReiforcements);

            Debug.Log(helloStutas);

            weapon.RankSet(test[0]);
            drowGachaRemaing--;
        }
    }
}
