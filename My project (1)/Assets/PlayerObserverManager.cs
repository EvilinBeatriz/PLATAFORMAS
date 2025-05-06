using System;
using UnityEngine;
//equivalente ao nosso youtube
public static class PlayerObserverManager
{
    //criar o canal de moedas do player
    public static event Action<int> OnMoedasChanged;
    
    //postar um video novo no canal (notifica os inscritos)
    public static void ChangedMoedas(int valor)
    {
        OnMoedasChanged?.Invoke(valor);
    }
}
