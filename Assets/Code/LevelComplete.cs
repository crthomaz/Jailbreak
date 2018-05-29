using Assets.Code;
using UnityEngine;

public class LevelComplete : MonoBehaviour {
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GameState.Instance.HandleStageCompletion();
            JailbreakSceneManager.Instance.LoadScene(GameState.LOADING);
        }
    }
}