using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    [SerializeField] private int numeroMax;

    // Start is called before the first frame update
    void Start()
    {
        List<int> lista = new List<int>();
        string mess;

        for(int i = 0; i < numeroMax; i++)
        {
            mess = "[]";
            if (i % 3 == 0)
                lista.Insert(0, i);
            else if (i % 3 == 1)
                lista.Insert(lista.Count, i);
            else
                lista.Insert(lista.Count / 2, i);
            for(int j = 0; j < lista.Count; j++)
            {
                mess = mess.Replace("]", "");
                if (j == 0)
                    mess += lista[j];
                else
                    mess += ", " + lista[j];
                mess += "]";
            }
            Debug.Log(mess);
        }
    }
}
