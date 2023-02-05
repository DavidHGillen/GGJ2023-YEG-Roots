using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip calmMusic;
    public AudioClip activeMusic;
    public AudioClip bossIntro;
    public AudioClip bossLoop;

    protected AudioSource sourceComp;

    public void Start()
    {
        sourceComp = gameObject.GetComponent<AudioSource>();
    }

    protected bool _isActive;
    public bool isActive
    {
        get { return _isActive; }
        set
        {
            if (value == _isActive) { return; }

            _isActive = value;
            handleChange();
        }
    }

    protected bool _isBoss;
    public bool isBoss
    {
        get { return _isBoss; }
        set
        {
            if (value == _isBoss) { return; }

            _isBoss = value;
            handleChange();
        }
    }

    ///////////////////////////////////

    void handleChange()
    {
        if(isBoss)
        {
            sourceComp.clip = bossLoop;
        } else {
            sourceComp.clip = isActive ? activeMusic : calmMusic;
        }

        sourceComp.Play();
    }

    public void calmMessage()
    {
        isActive = false;
    }

    public void dangerMessage()
    {
        isActive = true;
    }

    public void bossMessage()
    {
        isBoss = true;
    }
}
