using UnityEngine;
using System.Collections;

public class SceneGoTo : MonoBehaviour {

	
    public void OnButtonStartGameClick(int levelIndex)
    {
        Application.LoadLevel(levelIndex);
    }

    public void OnButtonBattleModeClick(int levelIndex)
    {
        Application.LoadLevel(levelIndex);
    }

    public void OnButtonLuShiModeClick(int levelIndex)
    {
        Application.LoadLevel(levelIndex);
    }
}
