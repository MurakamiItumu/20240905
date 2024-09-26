using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //インスタンスを保持するための静的な変数
    public static ScoreScript instance;

    //スコアの表示するためのtextコンポーネントとスコア
    public TextMeshProUGUI ScoreText;
    private int TotalScore = 0;

    private void Awake()
    {
        //インスタンスが存在していない場合は設定
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        //インスタンスが存在する場合は破棄
        else
        {
            Destroy(gameObject);
        }
    }
    //反映されるためのメソッド定義
    private void Start()
    {
        //初期設定
        Initialized();
    }
    //スコアを更新してtextコンポーネントに反映する
    public void ScoreManeger(int score)
    {
        TotalScore += score;
        //コンポーネントに表示
        UpdateScoreText();
    }
    //スコアをtextコンポーネントに表示するメソッド
    private void UpdateScoreText()
    {
        if(ScoreText != null)
        {
            ScoreText.text = "Score:" + TotalScore.ToString();
        }
    }
    //トータルスコア
    public int GetCurrenScore()
    {
        return TotalScore;
    }
    //初期化
    public void Initialized()
    {
        //スコアを取得してスコアを初期化させる

        

        
    }
}
