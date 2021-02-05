﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteraction : MonoBehaviour {

    public float gazeTime = 2f; // inisialisasi waktu tunggu
    private float timer; 
    private bool gazedAt;

    void Start()
    {

    }

    // proses untuk mengambil inputan dan waktu tunggu
    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime)
            {
                // execute pointerdown handler
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), 
                ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
    }

    public void PointerEnter()
    {
        gazedAt = true;
        // Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        gazedAt = false;
        // Debug.Log("PointerExit");
    }
}