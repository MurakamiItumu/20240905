using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    //�e��I�u�W�F�N�g�̐���
    public GameObject ScoreTextObject;//�X�R�A
    void Start()
    {
        this.ScoreTextObject.GetComponent<TextMeshProUGUI>().text = "Score:" + SceneData.score;
    }
}
