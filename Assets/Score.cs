using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Unity側でスコアのUIオブジェクトを設定する用の変数
    public GameObject ScoreObj;
    // スコア表示の文字を変更するためのTextコンポーネント
    private Text ScoreText;
    // 実際のスコアを保存するための変数
    private int ScoreNum = 0;
    private void Start()
    {
        // スコアのUIオブジェクトからTextコンポーネントを取得する
        ScoreText = ScoreObj.GetComponent<Text>();
    }
    private void Update()
    {
        // スコア表示の文字を更新する
        ScoreText.text = "Score:" + ScoreNum;
    }
    // スコアを加算するための関数
    // 引数にスコアに加算したい数値を設定すると自動的に加算される
    public void AddScore(int score)
    {
        // スコアを加算する
        ScoreNum += score;
    }
}
