using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequencerControllerScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource HighCPiano;
    public AudioSource BPiano;
    public AudioSource APiano;
    public AudioSource GPiano;
    public AudioSource FPiano;
    public AudioSource EPiano;
    public AudioSource DPiano;
    public AudioSource LowCPiano;

    int prevIndex = -1;
    int[] HighC_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] B_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] A_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] G_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] F_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] E_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] D_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] LowC_PlayArray = new int[32] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float nowTime = audioSource.time;
        AudioClip clip = audioSource.clip;
        float endTime = clip.length;
        float OneTimeLength = endTime / 32;
        int PlaySoundIndex = (int)(nowTime / OneTimeLength);
        //print(PlaySoundIndex);
        if (PlaySoundIndex != prevIndex){

            if (HighC_PlayArray[PlaySoundIndex] == 1)
            {
                HighCPiano.Play();
                print(PlaySoundIndex);
            }
            if (B_PlayArray[PlaySoundIndex] == 1)
            {
                BPiano.Play();
            }
            if (A_PlayArray[PlaySoundIndex] == 1)
            {
                APiano.Play();
            }
            if (G_PlayArray[PlaySoundIndex] == 1)
            {
                GPiano.Play();
            }
            if (F_PlayArray[PlaySoundIndex] == 1)
            {
                FPiano.Play();
            }
            if (E_PlayArray[PlaySoundIndex] == 1)
            {
                EPiano.Play();
            }
            if (D_PlayArray[PlaySoundIndex] == 1)
            {
                DPiano.Play();
            }
            if (LowC_PlayArray[PlaySoundIndex] == 1)
            {
                LowCPiano.Play();
            }
            prevIndex = PlaySoundIndex;
        }

    }
    public void HighCSoundPlayChange(int playSoundIndex)
    {
        if (HighC_PlayArray[playSoundIndex] == 0)
        {
            HighC_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            HighC_PlayArray[playSoundIndex] = 0;
        }
        print(HighC_PlayArray[playSoundIndex]);
    }
    public void BSoundPlayChange(int playSoundIndex)
    {
        if (B_PlayArray[playSoundIndex] == 0)
        {
            B_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            B_PlayArray[playSoundIndex] = 0;
        }
        print(B_PlayArray[playSoundIndex]);
    }
    public void ASoundPlayChange(int playSoundIndex)
    {
        if (A_PlayArray[playSoundIndex] == 0)
        {
            A_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            A_PlayArray[playSoundIndex] = 0;
        }
        print(A_PlayArray[playSoundIndex]);
    }
    public void GSoundPlayChange(int playSoundIndex)
    {
        if (G_PlayArray[playSoundIndex] == 0)
        {
            G_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            G_PlayArray[playSoundIndex] = 0;
        }
        print(G_PlayArray[playSoundIndex]);
    }
    public void FSoundPlayChange(int playSoundIndex)
    {
        if (F_PlayArray[playSoundIndex] == 0)
        {
            F_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            F_PlayArray[playSoundIndex] = 0;
        }
        print(F_PlayArray[playSoundIndex]);
    }
    public void ESoundPlayChange(int playSoundIndex)
    {
        if (E_PlayArray[playSoundIndex] == 0)
        {
            E_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            E_PlayArray[playSoundIndex] = 0;
        }
        print(E_PlayArray[playSoundIndex]);
    }
    public void DSoundPlayChange(int playSoundIndex)
    {
        if (D_PlayArray[playSoundIndex] == 0)
        {
            D_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            D_PlayArray[playSoundIndex] = 0;
        }
        print(D_PlayArray[playSoundIndex]);
    }
    public void LowCSoundPlayChange(int playSoundIndex)
    {
        if (LowC_PlayArray[playSoundIndex] == 0)
        {
            LowC_PlayArray[playSoundIndex] = 1;
        }
        else
        {
            LowC_PlayArray[playSoundIndex] = 0;
        }
        print(LowC_PlayArray[playSoundIndex]);
    }
}
