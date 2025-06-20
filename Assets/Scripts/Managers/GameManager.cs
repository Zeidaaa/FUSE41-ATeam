using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float m_changeSceneSec;
    [SerializeField]
    private float m_gameStartSec;

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

        }
    }
}
