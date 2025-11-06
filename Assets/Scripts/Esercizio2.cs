using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    [SerializeField] private string messaggio;

    // Start is called before the first frame update
    void Start()
    {
        int indiceParentesiChiusa = messaggio.IndexOf(")");
        if (messaggio[0] != '(' || indiceParentesiChiusa == -1)
        {
            Debug.LogError("Questo messaggio non è composto correttamente");
        }
        else
        {
            string messParentesi = messaggio.Substring(1, indiceParentesiChiusa - 1);
            string[] stringhe = messParentesi.Split(';');
            string dialogo = messaggio.Substring(indiceParentesiChiusa + 1);

            for(int i = 0; i < stringhe.Length; i++)
            {
                Debug.Log(stringhe[i]);
            }
            Debug.Log(dialogo);
        }

    }
}
