using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoAlbum : MonoBehaviour
{
    public List<Sprite> photoSprites; // List to store your photos
    public Image photoDisplay; // UI Image component to display the current photo

    private int currentIndex = 0; // Track the current photo index

    void Start()
    {
        if (photoSprites.Count > 0)
        {
            photoDisplay.sprite = photoSprites[currentIndex]; // Display the first photo
        }
    }

    public void NextPhoto()
    {
        if (currentIndex < photoSprites.Count - 1)
        {
            currentIndex++;
            photoDisplay.sprite = photoSprites[currentIndex]; // Display next photo
        }
    }

    public void PreviousPhoto()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            photoDisplay.sprite = photoSprites[currentIndex]; // Display previous photo
        }
    }
}

