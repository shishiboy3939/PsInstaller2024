using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class psc_main : MonoBehaviour
{

    public GameObject start_switch;
    public GameObject Push_switch;
    public GameObject Push_switch1;
    public GameObject Push_switch0;
    public GameObject Push_switch2;
    public GameObject Push_switch3;
    public GameObject Push_switch4;
    public GameObject Push_switch5;
    public GameObject Push_switch6;
    public GameObject Push_switch7;
    public GameObject Push_switch8;
    public GameObject Push_switch9;
    public GameObject Push_switch010;
    public GameObject Push_switch011;
    public GameObject to_lens;
    public GameObject to_display;
    public GameObject stage01;
    public GameObject stage01_player;
    public GameObject stage02_display2;
    public GameObject stage02_display3;
    public GameObject stage03;
    public GameObject stage04;
    public GameObject stage04_01;
    public GameObject stage04_02;
    public GameObject stage04_03;
    public GameObject stage04_04;
    public GameObject stage04_05;
    public GameObject stage04_06;
    //public GameObject stage04_06_text;
    public GameObject stage04_07;
    public GameObject step4_stage3;
    public GameObject step4_stage3_invitation;
    public GameObject step4_stage5;
    public GameObject Push_switch_sound;
    public GameObject Change_image_sound;
    public GameObject fin;
    public GameObject first_view;
    public GameObject nabi_0000;
    public GameObject player_0000;

    // Start is called before the first frame update
    void Start()
    {
        start_switch.SetActive(true);
        first_view.SetActive(true);
        to_display.SetActive(true);
        Push_switch.SetActive(true);
        Push_switch0.SetActive(false);
        Push_switch1.SetActive(false);
        Push_switch2.SetActive(false);
        Push_switch3.SetActive(false);
        Push_switch4.SetActive(false);
        Push_switch5.SetActive(false);
        Push_switch6.SetActive(false);
        Push_switch7.SetActive(false);
        Push_switch8.SetActive(false);
        Push_switch9.SetActive(false);
        Push_switch010.SetActive(false);
        Push_switch011.SetActive(false);
        to_lens.SetActive(false);
        stage01.SetActive(false);
        stage01_player.SetActive(false);
        stage02_display2.SetActive(false);
        stage02_display3.SetActive(false);
        stage03.SetActive(false);
        stage04.SetActive(false);
        stage04_01.SetActive(false);
        stage04_02.SetActive(false);
        stage04_03.SetActive(false);
        stage04_04.SetActive(false);
        stage04_05.SetActive(false);
        stage04_06.SetActive(false);
        stage04_07.SetActive(false);
        step4_stage3.SetActive(false);
        step4_stage3_invitation.SetActive(false);
        step4_stage5.SetActive(false);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(false);
       // stage04_06_text.SetActive(false);
        fin.SetActive(false);
        nabi_0000.SetActive(false);
        player_0000.SetActive(false);
    }

    void Update()
    {


        if (start_switch.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            
            Invoke("step1", 0.1f);

        }

        if (Push_switch1.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2", 0.1f);

        }
        if (Push_switch0.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_00", 0.1f);

        }
        if (Push_switch2.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_02", 0.1f);

        }
        if (Push_switch3.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_03", 0.1f);

        }
        if (Push_switch4.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_04", 0.1f);

        }
        if (Push_switch5.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_05", 0.1f);

        }
        if (Push_switch6.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_06", 0.1f);

        }
        if (Push_switch7.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step2_stage04_07", 0.1f);

        }
        if (Push_switch8.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step3", 0.1f);

        }
        if (Push_switch010.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("step4", 0.1f);

        }
        if (step4_stage3_invitation.activeSelf && Input.GetKeyDown(KeyCode.W))
        {
            Invoke("Restart", 0.1f);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("PsInstaller_240204");

        }
        



    }

    public void step1()
    {
        stage01.SetActive(true);
        stage04.SetActive(true);
        start_switch.SetActive(false);
        Push_switch.SetActive(false);
        first_view.SetActive(false);
        Invoke("step1_stop", 30.5f);

    }

    public void step1_stop()
    {
        stage01.SetActive(false);
        stage04.SetActive(false);
        first_view.SetActive(true);
        Invoke("Push_switch_command", 2.5f);
    }
    public void Push_switch_command()
    {
        Push_switch1.SetActive(true);
    }
    public void step2()
    {
        first_view.SetActive(false);
        player_0000.SetActive(true);
        nabi_0000.SetActive(true);
        Push_switch1.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_00_switch", 10.0f);
    }
    public void step2_stage04_00_switch()//ボタンが出てくる
    {
        Push_switch0.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }

    public void step2_stage04_00()//イメージが切り替わる
    {
        Push_switch0.SetActive(false);
        to_display.SetActive(false);
        stage01_player.SetActive(true);
        player_0000.SetActive(false);
        stage04_01.SetActive(true);
        nabi_0000.SetActive(false);
        to_lens.SetActive(true);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_01_switch", 5.0f);
        Push_switch_sound.SetActive(false);
    }


    public void step2_stage04_01_switch()
    {
        Push_switch2.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }


    public void step2_stage04_02()
    {
        stage04_01.SetActive(false);
        Push_switch2.SetActive(false);
        stage04_02.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_02_switch", 5.0f);
    }

    public void step2_stage04_02_switch()
    {
        Push_switch3.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
    public void step2_stage04_03()
    {
        stage04_02.SetActive(false);
        Push_switch3.SetActive(false);
        stage04_03.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_03_switch", 5.0f);
    }
    public void step2_stage04_03_switch()
    {
        Push_switch4.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
    public void step2_stage04_04()
    {
        stage04_03.SetActive(false);
        Push_switch4.SetActive(false);
        stage04_04.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_04_switch", 5.0f);
    }
    public void step2_stage04_04_switch()
    {
        Push_switch5.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
    public void step2_stage04_05()
    {
        stage04_04.SetActive(false);
        Push_switch5.SetActive(false);
        stage04_05.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_05_switch", 5.0f);
    }
    public void step2_stage04_05_switch()
    {
        Push_switch6.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
    public void step2_stage04_06()
    {
        stage04_05.SetActive(false);
        Push_switch6.SetActive(false);
        stage04_06.SetActive(true);
        //stage04_06_text.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_06_switch", 5.0f);
    }
    public void step2_stage04_06_switch()
    {
        Push_switch7.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
    public void step2_stage04_07()
    {
        stage04_06.SetActive(false);
       //stage04_06_text.SetActive(false);
        Push_switch7.SetActive(false);
        stage04_07.SetActive(true);
        Push_switch_sound.SetActive(false);
        Change_image_sound.SetActive(true);
        Invoke("step2_stage04_07_switch", 1.0f);
    }
    public void step2_stage04_07_switch()
    {
        Push_switch8.SetActive(true);
        Push_switch_sound.SetActive(true);
        Change_image_sound.SetActive(false);
    }
   
    public void step3()
    {
        Push_switch_sound.SetActive(false);
        to_lens.SetActive(false);
        stage04_07.SetActive(false);
        Push_switch8.SetActive(false);
        stage01_player.SetActive(false);
        stage02_display2.SetActive(true);
        stage02_display3.SetActive(true);
        Invoke("step3_stage2", 180.0f);

    }

    public void step3_stage2()
    {
        stage02_display2.SetActive(false);
        stage02_display3.SetActive(false);
        Push_switch010.SetActive(true);
        to_display.SetActive(true);
        first_view.SetActive(true);

    }

    public void step4()
    {
        Push_switch010.SetActive(false);
        step4_stage3.SetActive(true);
        step4_stage5.SetActive(true);
        first_view.SetActive(false);
        Invoke("step4_close", 66.5f);

    }
    public void step4_close()
    {
        step4_stage3.SetActive(false);
        step4_stage5.SetActive(false);
        step4_stage3_invitation.SetActive(true);
        fin.SetActive(true);
        Invoke("Restart", 15.0f);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Multidisplay_test");
    }

}