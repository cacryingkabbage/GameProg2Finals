using UnityEngine;
using UnityEngine.SceneManagement;

public class uianimation : MonoBehaviour
{
    [SerializeField] private Animator uiPanel;
    [SerializeField] private Animator stagePanel;

    public void StageSelected()
    {
        uiPanel.SetTrigger("Started");
    }

    public void StageAnimation()
    {
        stagePanel.SetTrigger("Stage");
    }
    public void LoadStage1()
    {
        SceneManager.LoadScene("GameScene1"); // Make sure this scene exists and is added to Build Settings
    }

    public void LoadStage2()
    {
        SceneManager.LoadScene("GameScene2");
    }
}
