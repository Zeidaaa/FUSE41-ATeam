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

    // シーンネームゲッター
    public string GetTitle() { return "TitleScene"; }
    public string GetExplanation() { return "ExplanationScene"; }
    public string GetGame() { return "GameScene"; }
    public string GetResult() { return "ResultScene"; }

    private void Awake()
    {
        // Scene間を跨げるようDDOLに設定
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
        // フェードインUIを再生
        SetIsControl(false);

        // 指定秒待つ
        yield return new WaitForSeconds(m_changeSceneSec);

        // 遷移
        SceneManager.LoadScene(SceneName);

        // フェードアウトUIを再生
        SetIsControl(true);

        // 遷移したシーンがゲームシーンなら
        if (SceneName == GetGame())
        {
            // ゲームスタートUIを再生

        }
    }
}
