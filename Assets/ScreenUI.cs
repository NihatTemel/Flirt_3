using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class ScreenUI : MonoBehaviour
{
    [SerializeField] GameObject EnergyRoot;
    [SerializeField] TMP_Text EnergyText;

    [SerializeField] GameObject Dialogpanel;
    [SerializeField] GameObject EnergyOutPanel;
    [SerializeField] Button EnergyoutButton;
    [SerializeField] TMP_Text EnergyOutText;

    [Header("Star / Hearth")]
    [SerializeField] Image Hearth_Img;
    [SerializeField] TMP_Text Hearthtext;
    [SerializeField] Image Star_Img;
    [SerializeField] TMP_Text Startext;

    float temptime;
    public int energytime;


    DateTime dt1;
    DateTime dt2;

    [SerializeField] int ReloadSeconds = 10;

    [Header("Mekan Img Text")]

    [SerializeField] GameObject MekanImage;
    [SerializeField] TMP_Text MekanText;


    void Start()
    {

        Debug.Log(PlayerPrefs.GetInt("girl")+ " name -> " + MekanImage.GetComponent<SpriteRenderer>().sprite.name);
        MekanText.text = "" + MekanImage.GetComponent<SpriteRenderer>().sprite.name;

        Application.targetFrameRate = 60;
        Hearthtext.text = "" + PlayerPrefs.GetInt("hearth");
        Startext.text = "" + PlayerPrefs.GetInt("totalstar");

        energytime = PlayerPrefs.GetInt("energy");
        if (PlayerPrefs.GetInt("newenergy") == 0) 
        {
            PlayerPrefs.SetInt("energysc", ReloadSeconds);
            PlayerPrefs.SetInt("newenergy", 1);
            PlayerPrefs.SetInt("energy", 5);
            PlayerPrefs.SetString("time2", DateTime.Now.ToShortDateString());
        }
        else 
        {
            if (PlayerPrefs.GetInt("energy") < 5) 
            {
                CheckForAfk();
                StartCoroutine(EnergyRecharge(PlayerPrefs.GetInt("energysc")));
                
            }
            else
            {
                EnergyText.text = "";
            }
            // CheckForAfk();
        }
        

        if (PlayerPrefs.GetInt("energy") < 1) 
        {
            Dialogpanel.SetActive(false);
            EnergyOutPanel.SetActive(true);
           
        }

        EneryLevel();     
    }


    public void TryAgain() 
    {
        if (PlayerPrefs.GetInt("energy") > 0)
            SceneManager.LoadScene(0);
    }

    public void WatchAddGain3Energy()
    {
        PlayerPrefs.SetInt("energy", 3);
        EneryLevel();
        EnergyoutButton.interactable = true;

    }
    void CheckForAfk() 
    {
        DateTime d2test = DateTime.Parse(PlayerPrefs.GetString("time2"));
        DateTime d1test = DateTime.Now;     //DateTime.Parse(PlayerPrefs.GetString("time1"));

        TimeSpan ts = d1test - d2test;

        if (ts.TotalSeconds > 10)
        {
            Debug.Log(ts.TotalSeconds + " saniye geçti");

            double passedtime = ts.TotalSeconds;
            int n = (int)Mathf.RoundToInt((float)passedtime);
            int point = n / ReloadSeconds;
            n -= (point * ReloadSeconds);
            PlayerPrefs.SetInt("energy", PlayerPrefs.GetInt("energy") + point);
            if (PlayerPrefs.GetInt("energy") > 5) 
            {
                PlayerPrefs.SetInt("energy", 5);
                PlayerPrefs.SetInt("energysc", ReloadSeconds);
            }
            PlayerPrefs.SetInt("energysc", PlayerPrefs.GetInt("energysc") - n);
        }
    }

    IEnumerator EnergyRecharge(int timesc)
    {
       

        if (PlayerPrefs.GetInt("energysc") < 0) 
        {
            PlayerPrefs.SetInt("energysc", ReloadSeconds);
        }

        for (int i = PlayerPrefs.GetInt("energysc"); i > 0; i--)
        {
            

            yield return new WaitForSeconds(1);


            dt2 = DateTime.Now;
            PlayerPrefs.SetString("time2", dt2.ToString());


            PlayerPrefs.SetInt("energysc", PlayerPrefs.GetInt("energysc") - 1);

            energytime = PlayerPrefs.GetInt("energysc");

            int min = energytime / 60;
            int sc = energytime - (60 * min);


            if (min < 10) 
            {
                if(sc>9)
                    EnergyText.text = "0" + min + ":" + sc;

                else
                {
                    EnergyText.text ="0"+ min + ":0" + sc;

                }

            }
            if (EnergyoutButton.gameObject.activeInHierarchy) 
            {
                EnergyOutText.text = EnergyText.text;
                EnergyText.fontSize = 0;
                if (PlayerPrefs.GetInt("energy") > 0)
                    EnergyoutButton.interactable = true;
            }
            
        }
        
        PlayerPrefs.SetInt("energysc", ReloadSeconds);
        PlayerPrefs.SetInt("energy", 1 + PlayerPrefs.GetInt("energy"));
        EneryLevel();
        if (PlayerPrefs.GetInt("energy") != 5) 
        {
            StartCoroutine(EnergyRecharge(10));
        }
        else 
        {
            EnergyText.text = "";
        }

    }



   public void EneryLevel() 
    {
        int n = PlayerPrefs.GetInt("energy");

        if (n > 5)
            n = 5;

        for (int i = 0; i < n; i++)
        {
          
            EnergyRoot.transform.GetChild(i).gameObject.SetActive(true);
        }
    }


    public void HearthPlus()
    {
        Vector3 originalSize = Hearth_Img.rectTransform.localScale;
        Hearth_Img.rectTransform.DOScale(originalSize * 2.2f, 0.6f)
           .OnComplete(() => Hearth_Img.rectTransform.DOScale(originalSize, 0.5f));


        PlayerPrefs.SetInt("hearth", PlayerPrefs.GetInt("hearth") + 1);
        Hearthtext.text = "" + PlayerPrefs.GetInt("hearth");
    }

    public void StarPlus()
    {
        Vector3 originalSize = Star_Img.rectTransform.localScale;
        Star_Img.rectTransform.DOScale(originalSize * 2.2f, 0.2f)
           .OnComplete(() => Star_Img.rectTransform.DOScale(originalSize, 0.3f));


        PlayerPrefs.SetInt("totalstar", PlayerPrefs.GetInt("totalstar") + 1);
        Startext.text = "" + PlayerPrefs.GetInt("totalstar");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PlayerPrefs.SetInt("energy", PlayerPrefs.GetInt("energy") - 1);
        if(Input.GetKeyDown(KeyCode.F)) PlayerPrefs.SetInt("energy", 5);
    }
}
