using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    //各種オブジェクトの生成
    public GameObject ScoreTextObject;//スコア
    void Start()
    {
        this.ScoreTextObject.GetComponent<TextMeshProUGUI>().text = "Score:" + SceneData.score;
    }
}
