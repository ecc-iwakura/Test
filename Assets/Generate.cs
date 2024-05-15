using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    // 複製したいオブジェクトを設定しておく変数
    public GameObject Object;
    // 複製タイミングを調整するためのタイマー
    public float Interval = 1.0f;   // 生成間隔(秒)、Unity側で調整可能
    private float Timer = 0.0f;    // カウントアップ用タイマー
    private void Update()
    {
        // タイマー加算
        Timer += Time.deltaTime;
        // タイマーが生成間隔の時間を超えているか確認
        if (Timer >= Interval)
        {  // 超えていた場合は中括弧内の処理が実行される

            // Instantiate関数でObjectを複製する
            // 書き方とカッコ内で渡している内容の意味
            // Instantiate( 複製したいGameObject , 複製する場所 , 複製する向き )
            Instantiate(Object, transform.position, transform.rotation);
            // タイマーをリセット
            Timer = 0.0f;
        }  // タイマーが生成間隔を超えていた場合の処理はここまで
    }
    private void Start()
    {

    }
}
