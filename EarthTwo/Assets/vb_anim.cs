using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    Texture2D texture;
    Texture2D texture2;
    Texture2D texture3;
    Texture2D texture4, texture5, texture6, texture7;
    Texture2D texture8, texture9, texture10, texture11, texture12, texture13, texture14, texture15, texture16, texture17;
    Texture2D texture18, texture19, texture20, texture21, texture22, texture23, texture24, texture25, texture26, texture27;
    Texture2D texture28, texture29, texture30, texture31, texture32, texture33, texture34, texture35;
    int switcher;
    int switcher2;
    public GameObject vbBtnObj1;
    public GameObject vbBtnObj2;
    public GameObject vbBtnObj3;
    public GameObject vbBtnObj4;
    public GameObject bolita;
    //public string url = "";
    //public Renderer thisRenderer;
    // Use this for initialization
    void Start()
    {
        texture = (Texture2D)Resources.Load("mapamundi");
        texture2 = (Texture2D)Resources.Load("1temp");
        texture3 = (Texture2D)Resources.Load("1pressure");
        texture4 = (Texture2D)Resources.Load("veldeshielo");
        texture5 = (Texture2D)Resources.Load("plotg1");
        texture6 = (Texture2D)Resources.Load("plotg2");
        texture7 = (Texture2D)Resources.Load("plotg3");
        texture8 = (Texture2D)Resources.Load("plotg4");
        texture9 = (Texture2D)Resources.Load("plotg5");
        texture10 = (Texture2D)Resources.Load("plotg6");
        texture11 = (Texture2D)Resources.Load("plotg7");
        texture12 = (Texture2D)Resources.Load("plotg8");
        texture13 = (Texture2D)Resources.Load("plotg10");
        texture14 = (Texture2D)Resources.Load("plotg11");
        texture15 = (Texture2D)Resources.Load("plotg12");
        texture16 = (Texture2D)Resources.Load("plotg13");
        texture17 = (Texture2D)Resources.Load("plotg14");
        texture18 = (Texture2D)Resources.Load("plotg15");
        texture19 = (Texture2D)Resources.Load("plotg16");
        texture20 = (Texture2D)Resources.Load("plotg17");
        texture21 = (Texture2D)Resources.Load("plotg18");
        /*texture22 = (Texture2D)Resources.Load("mapamundi color");
        texture23= (Texture2D)Resources.Load("mapa3");
        texture24= (Texture2D)Resources.Load("mapa4");
        texture25 = (Texture2D)Resources.Load("mapamundi");
        texture26 = (Texture2D)Resources.Load("mapamundi color");
        texture27 = (Texture2D)Resources.Load("mapa3");
        texture28 = (Texture2D)Resources.Load("mapa4");
        texture29 = (Texture2D)Resources.Load("mapamundi");
        texture30 = (Texture2D)Resources.Load("mapamundi color");
        texture31 = (Texture2D)Resources.Load("mapa3");
        texture32 = (Texture2D)Resources.Load("mapa4");
        texture33 = (Texture2D)Resources.Load("mapamundi");
        texture34 = (Texture2D)Resources.Load("mapamundi color");
        texture35 = (Texture2D)Resources.Load("mapa3");*/

        //vbBtnObj = GameObject.Find("ButtonOne");
        //vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        //StartCoroutine(LoadFromLikeCoroutine());

        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        // Find the models based on the names in the Hierarchy
        vbBtnObj1 = GameObject.Find("ButtonOne");
        vbBtnObj2 = GameObject.Find("ButtonTwo");
        // vbBtnObj3 = GameObject.Find("ButtonThree");
        //vbBtnObj4 = GameObject.Find("ButtonFour");
        bolita = GameObject.Find("Sphere");
        //vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = true;
        //vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = true;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Pressed");
        Debug.Log("SW1: " + switcher);
        //Debug.Log("SW2: " + switcher2);
        switch (vb.VirtualButtonName)
        {
            case "ButtonOne":
                switcher++;
                //switcher2 = 0;
                if (switcher > 21) { switcher = 21; }
                Selector(switcher);
                Debug.Log("Btn1 Pressed");
                //bolita.GetComponent<Renderer>().material.mainTexture = texture;
                break;
            case "ButtonTwo":
                switcher--;
                //switcher2 = 0;
                if (switcher < 1) { switcher = 1; }
                Selector(switcher);
                Debug.Log("Btn2 Pressed");
                //bolita.GetComponent<Renderer>().material.mainTexture = texture2;
                break;
                /*case "ButtonThree":
                    switcher2++;
                    if (switcher2 >15) { switcher2 = 15; }
                    Selector2(switcher,switcher2);
                    Debug.Log("Btn3 Pressed");
                    //bolita.GetComponent<Renderer>().material.mainTexture = texture2;
                    break;
                case "ButtonFour":
                    switcher2--;
                    if (switcher2 < 1) { switcher2 = 1; }
                    Selector2(switcher,switcher2);
                    Debug.Log("Btn4 Pressed");
                    //bolita.GetComponent<Renderer>().material.mainTexture = texture2;
                    break;*/

        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Btn Released");
    }

    public void Selector(int s)
    {
        switch (s)
        {
            case 1:
                /*vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = false;
                vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = false;*/
                bolita.GetComponent<Renderer>().material.mainTexture = texture;
                break;
            case 2:
                /*vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = false;
                vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = false;*/
                bolita.GetComponent<Renderer>().material.mainTexture = texture2;
                break;
            case 3:
                /*vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = false;
                vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = false;*/
                bolita.GetComponent<Renderer>().material.mainTexture = texture3;
                break;
            case 4:
                /*vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = true;
                vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = true;*/
                bolita.GetComponent<Renderer>().material.mainTexture = texture4;
                break;
            case 5:
                /*vbBtnObj3.GetComponent<VirtualButtonBehaviour>().enabled = true;
                vbBtnObj4.GetComponent<VirtualButtonBehaviour>().enabled = true;*/
                bolita.GetComponent<Renderer>().material.mainTexture = texture5;
                break;
            case 6:
                bolita.GetComponent<Renderer>().material.mainTexture = texture6;
                break;
            case 7:
                bolita.GetComponent<Renderer>().material.mainTexture = texture7;
                break;
            case 8:
                bolita.GetComponent<Renderer>().material.mainTexture = texture8;
                break;
            case 9:
                bolita.GetComponent<Renderer>().material.mainTexture = texture9;
                break;
            case 10:
                bolita.GetComponent<Renderer>().material.mainTexture = texture10;
                break;
            case 11:
                bolita.GetComponent<Renderer>().material.mainTexture = texture11;
                break;
            case 12:
                bolita.GetComponent<Renderer>().material.mainTexture = texture12;
                break;
            case 13:
                bolita.GetComponent<Renderer>().material.mainTexture = texture13;
                break;
            case 14:
                bolita.GetComponent<Renderer>().material.mainTexture = texture14;
                break;
            case 15:
                bolita.GetComponent<Renderer>().material.mainTexture = texture15;
                break;
            case 16:
                bolita.GetComponent<Renderer>().material.mainTexture = texture16;
                break;
            case 17:
                bolita.GetComponent<Renderer>().material.mainTexture = texture17;
                break;
            case 18:
                bolita.GetComponent<Renderer>().material.mainTexture = texture18;
                break;
            case 19:
                bolita.GetComponent<Renderer>().material.mainTexture = texture19;
                break;
            case 20:
                bolita.GetComponent<Renderer>().material.mainTexture = texture20;
                break;
            case 21:
                bolita.GetComponent<Renderer>().material.mainTexture = texture21;
                break;
        }

    }

    /*  public void Selector2(int s1, int s2)
      {
          if (s1 == 4 && s2 == 1) { bolita.GetComponent<Renderer>().material.mainTexture = texture6; }
          if (s1 == 4 && s2 == 2) { bolita.GetComponent<Renderer>().material.mainTexture = texture7; }
          if (s1 == 4 && s2 == 3) { bolita.GetComponent<Renderer>().material.mainTexture = texture8; }
          if (s1 == 4 && s2 == 4) { bolita.GetComponent<Renderer>().material.mainTexture = texture9; }
          if (s1 == 4 && s2 == 5) { bolita.GetComponent<Renderer>().material.mainTexture = texture10; }
          if (s1 == 4 && s2 == 6) { bolita.GetComponent<Renderer>().material.mainTexture = texture11; }
          if (s1 == 4 && s2 == 7) { bolita.GetComponent<Renderer>().material.mainTexture = texture12; }
          if (s1 == 4 && s2 == 8) { bolita.GetComponent<Renderer>().material.mainTexture = texture13; }
          if (s1 == 4 && s2 == 9) { bolita.GetComponent<Renderer>().material.mainTexture = texture14; }
          if (s1 == 4 && s2 == 10) { bolita.GetComponent<Renderer>().material.mainTexture = texture15; }
          if (s1 == 4 && s2 == 11) { bolita.GetComponent<Renderer>().material.mainTexture = texture16; }
          if (s1 == 4 && s2 == 12) { bolita.GetComponent<Renderer>().material.mainTexture = texture17; }
          if (s1 == 4 && s2 == 13) { bolita.GetComponent<Renderer>().material.mainTexture = texture18; }
          if (s1 == 4 && s2 == 14) { bolita.GetComponent<Renderer>().material.mainTexture = texture19; }
          if (s1 == 4 && s2 == 15) { bolita.GetComponent<Renderer>().material.mainTexture = texture20; }

          if (s1 == 5 && s2 == 1) { bolita.GetComponent<Renderer>().material.mainTexture = texture21; }
          if (s1 == 5 && s2 == 2) { bolita.GetComponent<Renderer>().material.mainTexture = texture22; }
          if (s1 == 5 && s2 == 3) { bolita.GetComponent<Renderer>().material.mainTexture = texture23; }
          if (s1 == 5 && s2 == 4) { bolita.GetComponent<Renderer>().material.mainTexture = texture24; }
          if (s1 == 5 && s2 == 5) { bolita.GetComponent<Renderer>().material.mainTexture = texture25; }
          if (s1 == 5 && s2 == 6) { bolita.GetComponent<Renderer>().material.mainTexture = texture26; }
          if (s1 == 5 && s2 == 7) { bolita.GetComponent<Renderer>().material.mainTexture = texture27; }
          if (s1 == 5 && s2 == 8) { bolita.GetComponent<Renderer>().material.mainTexture = texture28; }
          if (s1 == 5 && s2 == 9) { bolita.GetComponent<Renderer>().material.mainTexture = texture29; }
          if (s1 == 5 && s2 == 10) { bolita.GetComponent<Renderer>().material.mainTexture = texture30; }
          if (s1 == 5 && s2 == 11) { bolita.GetComponent<Renderer>().material.mainTexture = texture31; }
          if (s1 == 5 && s2 == 12) { bolita.GetComponent<Renderer>().material.mainTexture = texture32; }
          if (s1 == 5 && s2 == 13) { bolita.GetComponent<Renderer>().material.mainTexture = texture33; }
          if (s1 == 5 && s2 == 14) { bolita.GetComponent<Renderer>().material.mainTexture = texture34; }
          if (s1 == 5 && s2 == 15) { bolita.GetComponent<Renderer>().material.mainTexture = texture35; }

      }*/

    // Update is called once per frame
    void Update()
    {

    }
}