using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float m_changeSceneSec;

    private void Awake()
    {
        // Scene間を跨げるようDDOLに設定
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
        // フェードインUIを再生


        // 指定秒待つ
        yield return new WaitForSeconds(m_changeSceneSec);

        // 遷移
        SceneManager.LoadScene(SceneName);
    }
}
