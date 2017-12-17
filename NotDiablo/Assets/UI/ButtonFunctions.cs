using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour {

	public GameObject mainPanel;
	public GameObject optionsPanel;
	public GameObject classPanel;
	public GameObject meleePlayer, rangedPlayer;
	void Start () {
		optionsPanel.SetActive(false);
		classPanel.SetActive(false);
	}
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
		Instantiate(meleePlayer, Vector3.zero, Quaternion.identity);
	}
	public void ChooseRanged()
	{
		SceneManager.LoadScene("Scene");
		Instantiate(rangedPlayer, Vector3.zero, Quaternion.identity);
	}
}
