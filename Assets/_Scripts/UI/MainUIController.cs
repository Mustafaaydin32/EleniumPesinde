using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.UI
{
    /// <summary>
    /// A simple controller for switching between UI panels.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        public GameObject[] panels;
        public GameObject ayarlarPaneli;

        public void SetActivePanel(int index)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                var active = i == index;
                var g = panels[i];
                if (g.activeSelf != active) g.SetActive(active);
            }
        }

        
        // Ana menüdeki OYNA butonuna basınca çalışacak fonksiyon
        public void PlayGame()
        {
            SceneManager.LoadScene("Bolum1"); // "Bolum1" sahnesini yükler
        }

        // ÇIKIŞ butonuna basınca çalışacak fonksiyon
        public void QuitGame()
        {
            Debug.Log("Oyundan çıkıldı!");
            Application.Quit();
        }
        // Ayarlar butonuna basınca paneli açacak fonksiyon
        public void OpenOptions()
        {
            ayarlarPaneli.SetActive(true); // Paneli görünür yapar
        }

        // Kapat butonuna basınca paneli gizleyecek fonksiyon
        public void CloseOptions()
        {
            ayarlarPaneli.SetActive(false); // Paneli gizler
        }
    }
}