using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolController : MonoBehaviour
{
    public int sayi = 0;
    public string operationTag; // Ýþlemi belirleyen tag

    private int targetNumber; // Hedef sayý

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player")) // Oyuncu sembole temas ettiðinde
        {
            //GameManager.Instance.SetTargetNumber(targetNumber); // GameManager'a hedef sayýyý bildirme
            //GameManager.Instance.StartOperation(operationTag); // GameManager'a iþlemi baþlatma komutu verme



            if (gameObject.CompareTag("Addition")) // Toplama sembolüne temas
            {
                GameManager.Instance.StartOperation("Addition"); // Toplama iþlemi baþlatma
                sayi = sayi + RandomKodu.Instance.tutulanSayi;
            }
            else if (gameObject.CompareTag("Substraction")) // Çýkarma sembolüne temas
            {
                GameManager.Instance.StartOperation("Substraction"); // Çýkarma iþlemi baþlatma
                sayi = sayi - RandomKodu.Instance.tutulanSayi;
            }
            else if (gameObject.CompareTag("Multiplication")) // Çarpma sembolüne temas
            {
                GameManager.Instance.StartOperation("Multiplication"); // Çarpma iþlemi baþlatma
                sayi = sayi * RandomKodu.Instance.tutulanSayi;
            }

            Debug.Log(sayi);

            if (sayi == HedefRandom.Instance.randomHedef)
            {
                HedefRandom.Instance.RandomStart();
            }


            Destroy(gameObject); // Sembolü yok etme

        }
    }

    public void SetTargetNumber(int number)
    {
        targetNumber = number; // Hedef sayýyý belirleme
    }
}
