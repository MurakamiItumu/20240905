using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�C���X�^���X��ێ����邽�߂̐ÓI�ȕϐ�
    public static ScoreScript instance;

    //�X�R�A�̕\�����邽�߂�text�R���|�[�l���g�ƃX�R�A
    public TextMeshProUGUI ScoreText;
    private int TotalScore = 0;

    private void Awake()
    {
        //�C���X�^���X�����݂��Ă��Ȃ��ꍇ�͐ݒ�
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        //�C���X�^���X�����݂���ꍇ�͔j��
        else
        {
            Destroy(gameObject);
        }
    }
    //���f����邽�߂̃��\�b�h��`
    private void Start()
    {
        //�����ݒ�
        Initialized();
    }
    //�X�R�A���X�V����text�R���|�[�l���g�ɔ��f����
    public void ScoreManeger(int score)
    {
        TotalScore += score;
        //�R���|�[�l���g�ɕ\��
        UpdateScoreText();
    }
    //�X�R�A��text�R���|�[�l���g�ɕ\�����郁�\�b�h
    private void UpdateScoreText()
    {
        if(ScoreText != null)
        {
            ScoreText.text = "Score:" + TotalScore.ToString();
        }
    }
    //�g�[�^���X�R�A
    public int GetCurrenScore()
    {
        return TotalScore;
    }
    //������
    public void Initialized()
    {
        //�X�R�A���擾���ăX�R�A��������������

        

        
    }
}
