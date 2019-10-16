using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard1 : MonoBehaviour
{
    int min = 1;
    int max = 1001;
    int guess = 500;





    void Start()
    {
        print("Witaj u liczbowego czarodzieja!");
        print("Pomyśl sobie liczbę ale nie mów jej na głos");

        print("Minimalna liczba jaką możesz wybrać to: " + min);
        print("Maksymalna liczba jaką możesz wybrać to: " + max);
        print("Naciśnij Górną strzałkę aby potwierdzić że jest większa");
        print("Naciśnij Dolną strzałkę aby potwierdzić że jest mniejsza");
        print("Naciśniej Enter aby potwierdzić że zgadłem");
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest mnniejsza czy większa niż  " + guess);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            print("Czy twoja liczba jest mnniejsza czy większa niż " + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Haha zgadłem twoją liczbę!");
        }
    }

}
       
        


        
