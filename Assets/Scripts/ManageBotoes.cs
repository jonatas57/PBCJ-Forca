using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageBotoes : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    PlayerPrefs.SetInt("score", 0);
  }

  // Update is called once per frame
  void Update() {

  }

  public void StartMundoGame() {
    SceneManager.LoadScene("Lab1");
  }

  public void VoltarParaMenuInicial() {
    SceneManager.LoadScene("Lab1_start");
  }

  public void Sair() {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
  }
}
