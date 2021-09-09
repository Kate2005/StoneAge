using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintInformation : MonoBehaviour
{
    CarClass porshe = new CarClass();
    CarClass reno = new CarClass();
    
    CarClass lambo = new CarClass("Lamborgini");
    CarClass gaz2109 = new CarClass("GAZ2109", 50, EngineType.Gasoline);
    Transport audi = new Transport();
    
    [SerializeField] CarClass gaz1111;
    [SerializeField] List<CarClass> carClasses;

    private void Start()
    {
        Transport.height = 50f;
        print(Transport.height);

        porshe.name = "Порше";
        porshe.hoursePower = 300;
        porshe.engineType = EngineType.Gasoline;
        
        reno.name = "Рено";
        reno.hoursePower = 100;
        reno.engineType = EngineType.Disel;

        porshe.GetInfo();
    }
}
