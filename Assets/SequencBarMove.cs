using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencBarMove : MonoBehaviour
{
    public AudioSource audioSource;
    public RectTransform nowBar;
    public RectTransform endBar;

    float nowX;
    float startX;
    float endX;

    // Start is called before the first frame update
    void Start()
    {
        startX = nowBar.localPosition.x;
        endX = endBar.localPosition.x;
        print(startX);
        print(endX);
        nowX = startX;
    }

    // Update is called once per frame
    void Update()
    {
        float nowTime = audioSource.time;
        //print(nowTime);
        AudioClip clip = audioSource.clip;
        float endTime = clip.length;
        //print(endTime);
        //nowX = nowX + 1;
        //------
        float retio = nowTime / endTime;
        float posXLength = endX - startX;
        float nowBarX = posXLength * retio;
        nowX = startX + nowBarX;
        //------
        nowBar.localPosition = new Vector3(nowX, nowBar.localPosition.y, nowBar.localPosition.z);
    }
}
