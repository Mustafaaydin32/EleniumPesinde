using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    [Header("Can Ayarlari")]
    public int maxCan = 3;
    private int mevcutCan;

    void Start()
    {
        mevcutCan = maxCan;
    }

    // Karakter hasar aldýðýnda (düþmana çarpýnca vb.) çaðrýlacak fonksiyon
    public void HasarAl(int hasarMiktari)
    {
        mevcutCan -= hasarMiktari;
        Debug.Log("Karakter hasar aldi! Kalan Can: " + mevcutCan);

        // Caný 0 veya daha altýna düþtüyse ölüm fonksiyonunu çalýþtýr
        if (mevcutCan <= 0)
        {
            Olum();
        }
    }

    void Olum()
    {
        Debug.Log("Karakter öldü! Yeniden dogduruluyor...");
        // Yarýn buraya karakterin baþlangýç noktasýna ýþýnlanma kodunu yazacaðýz.
    }
}
