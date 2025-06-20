using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // �V�[���l�[���\����
    [HideInInspector]
    public struct S_SceneNames
    {
        public string GetTitle() { return "TitleScene"; }
        public string GetExplanation() { return "ExplanationScene"; }
        public string GetGame() { return "GameScene"; }
        public string GetResult() { return "ResultScene"; }
    }
    
    [SerializeField]
    private float m_changeSceneSec;

    private void Awake()
    {
        // Scene�Ԃ��ׂ���悤DDOL�ɐݒ�
        DontDestroyOnLoad(gameObject);
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
        Debug.Log("OK2");

        // �w��b�҂�
        yield return new WaitForSeconds(m_changeSceneSec);

        // �J��
        SceneManager.LoadScene(SceneName);
    }
}
