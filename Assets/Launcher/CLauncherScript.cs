using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class CLauncherScript : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        Screen.SetResolution(800, 600, false, 60);
    }
    #region Public変数定義

    //Public変数の定義はココで

    #endregion

    #region Private変数
    //Private変数の定義はココで
    #endregion

    #region Public Methods
    //ログインボタンを押したときに実行される
    public void Connect()
    {
        //Photonに接続できていなければ
        if (!PhotonNetwork.IsConnected)
        {
            PhotonNetwork.ConnectUsingSettings();   //Photonに接続する
            Debug.Log("Photonに接続しました。");
            if (string.IsNullOrEmpty(PhotonNetwork.NickName))
            {
                PhotonNetwork.NickName = "player" + Random.Range(1, 99999);
            }
            Invoke("ToLobby", 0.3f);
        }
    }
    #endregion

    public void EndGame()
    {
        Invoke("Quit", 0.3f);
    }

    void OnGUI()
    {
        //ログインの状態を画面上に出力
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }

    void ToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}