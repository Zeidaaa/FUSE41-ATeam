using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[System.Serializable]
public struct S_BSpeedChangeScore
{
    public float ChangeSpeed;
    public int ChangeScore;
}

public class GameManager : MonoBehaviour
{
    // �t�F�[�h�C���A�E�g�̒�~����
    [SerializeField]
    private float m_changeSceneSec;
    
    // �X�R�A
    private int m_score;
    public void AddScore() { m_score++; }
    public void ResetScore() { m_score = 0; }
    public int GetScore() {  return m_score; }

    // �R���g���[���[�̐���t���O
    private bool m_isControl;
    public void SetIsControl(bool Is) { m_isControl = Is; }
    public bool GetIsControl() { return m_isControl; }

    // �V�[���l�[���Q�b�^�[
    public string GetTitle() { return "TitleScene"; }
    public string GetExplanation() { return "ExplanationScene"; }
    public string GetGame() { return "GameScene"; }
    public string GetResult() { return "ResultScene"; }

    private void Awake()
    {
        // Scene�Ԃ��ׂ���悤DDOL�ɐݒ�
        DontDestroyOnLoad(gameObject);

        ResetScore();
        SetIsControl(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public IEnumerator OnChangeScene(string SceneName)
    {
        // �t�F�[�h�C��UI���Đ�
        SetIsControl(false);

        // �w��b�҂�
        yield return new WaitForSeconds(m_changeSceneSec);

        // �J��
        SceneManager.LoadScene(SceneName);

        // �t�F�[�h�A�E�gUI���Đ�
        SetIsControl(true);

        // �J�ڂ����V�[�����Q�[���V�[���Ȃ�
        if (SceneName == GetGame())
        {
            // �Q�[���X�^�[�gUI���Đ�

            // �X�R�A�����Z�b�g
            ResetScore();
        }
    }
}
