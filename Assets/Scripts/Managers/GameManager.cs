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
    // フェードインアウトの停止時間
    [SerializeField]
    private float m_changeSceneSec;
    
    // スコア
    private int m_score;
    public void AddScore() { m_score++; }
    public void ResetScore() { m_score = 0; }
    public int GetScore() {  return m_score; }

    // コントローラーの制御フラグ
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

            // スコアをリセット
            ResetScore();
        }
    }
}
