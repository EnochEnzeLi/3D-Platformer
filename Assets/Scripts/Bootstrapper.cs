using Unity.Netcode;
using UnityEditor;
using UnityEngine;

public class Bootstrapper : NetworkBehaviour
{
    public SceneAsset gameScene;
    public void LoadGameScene()
    {
        if(IsServer)
            NetworkManager.Singleton.SceneManager.LoadScene(gameScene.name, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
