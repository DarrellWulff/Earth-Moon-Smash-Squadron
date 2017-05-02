using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {


    public Text playerHealth;
    public BoatShipDamage boat;
    public GameObject GameOverScreen;

    public Text amountofRocktopus;
    public Text amountofMeteor;
    public Text Total;

    public int meteorNum;
    public int octoNum;
    public int totalnum;


    // Use this for initialization
    void Start () {
        Time.timeScale = 1;

    }
	
	// Update is called once per frame
	void Update ()
    {
        playerHealth.text = boat.PlayerHealth.ToString();

        if(boat.PlayerHealth <= 0)
        {
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);
            Cursor.visible = true;

            meteorNum = MeteorLogic.amountOfMeteor;
            amountofMeteor.text = meteorNum.ToString();

            octoNum = Rocktopus.amountOfRocktopus;
            amountofRocktopus.text = octoNum.ToString();

            totalnum = octoNum + meteorNum;
            Total.text = totalnum.ToString();
        }

        if (Input.GetKey(KeyCode.Escape)) { Application.Quit(); }
	}

    public void Yes()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    
}
