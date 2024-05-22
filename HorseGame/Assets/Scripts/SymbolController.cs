using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolController : MonoBehaviour
{
    public int sayi = 0;
    public string operationTag; // ��lemi belirleyen tag

    private int targetNumber; // Hedef say�

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player")) // Oyuncu sembole temas etti�inde
        {
            //GameManager.Instance.SetTargetNumber(targetNumber); // GameManager'a hedef say�y� bildirme
            //GameManager.Instance.StartOperation(operationTag); // GameManager'a i�lemi ba�latma komutu verme



            if (gameObject.CompareTag("Addition")) // Toplama sembol�ne temas
            {
                GameManager.Instance.StartOperation("Addition"); // Toplama i�lemi ba�latma
                sayi = sayi + RandomKodu.Instance.tutulanSayi;
            }
            else if (gameObject.CompareTag("Substraction")) // ��karma sembol�ne temas
            {
                GameManager.Instance.StartOperation("Substraction"); // ��karma i�lemi ba�latma
                sayi = sayi - RandomKodu.Instance.tutulanSayi;
            }
            else if (gameObject.CompareTag("Multiplication")) // �arpma sembol�ne temas
            {
                GameManager.Instance.StartOperation("Multiplication"); // �arpma i�lemi ba�latma
                sayi = sayi * RandomKodu.Instance.tutulanSayi;
            }

            Debug.Log(sayi);

            if (sayi == HedefRandom.Instance.randomHedef)
            {
                HedefRandom.Instance.RandomStart();
            }


            Destroy(gameObject); // Sembol� yok etme

        }
    }

    public void SetTargetNumber(int number)
    {
        targetNumber = number; // Hedef say�y� belirleme
    }
}
