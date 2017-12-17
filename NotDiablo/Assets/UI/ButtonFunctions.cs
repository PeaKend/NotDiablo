using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

	// Use this for initialization
	public GameObject mainPanel;
	public GameObject optionsPanel;
	public GameObject classPanel;
	public GameObject meleePlayer, rangedPlayer;
	void Start () {
		optionsPanel.SetActive(false);
		classPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void StartGame()
	{
		classPanel.SetActive(true);
		mainPanel.SetActive(false);
	}
	public void OpenOptions()
	{
		optionsPanel.SetActive(true);
		mainPanel.SetActive(false);
	}
	public void ExitGame()
	{
	}
	public void BackToMain()
	{
		optionsPanel.SetActive(false);
		classPanel.SetActive(false);
		mainPanel.SetActive(true);
	}
	public void ChooseMelee()
	{
		SceneManager.LoadScene("Scene");
		Scene s = SceneManager.GetSceneByName("Scene");
		GameObject player = Instantiate(meleePlayer, Vector3.zero, Quaternion.identity);
		SceneManager.MoveGameObjectToScene(player, s);
		//SceneManager.SetActiveScene(s);
	}
	public void ChooseRanged()
	{
		SceneManager.LoadScene("Scene");
		Scene s = SceneManager.GetSceneByName("Scene");
		GameObject player = Instantiate(rangedPlayer, Vector3.zero, Quaternion.identity);
		//SceneManager.MoveGameObjectToScene(player, s);
		//SceneManager.SetActiveScene(s);
	}
}
