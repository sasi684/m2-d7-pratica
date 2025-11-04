using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{

    [SerializeField] private int punteggio1, punteggio2, danno;
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        Enemy e1 = new Enemy();

        p1.nome = "Pippo";
        p1.SetPunteggio(punteggio1);

        p2.nome = "Paperino";
        p2.SetPunteggio(punteggio2);

        e1.nome = "Topolino";
        e1.livello = 10;
        e1.salute = 100;

        Debug.Log($"Giocatore 1 di nome {p1.nome} con punteggio di {p1.GetPunteggio()}");
        Debug.Log($"Giocatore 2 di nome {p2.nome} con punteggio di {p2.GetPunteggio()}");

        //p1.IncrementaPunteggio(50);
        //Debug.Log("Punteggio aumentato " +  p1.punteggio);


        if (p1.IsVincitore())
        {
            Debug.Log($"{p1.nome} è il vincitore");
        }
        if (p2.IsVincitore())
        {
            Debug.Log($"{p2.nome} è il vincitore");
        }

        p1.AttaccaNemico(e1, danno);
        Debug.Log($"Adesso {e1.nome} ha {e1.salute}hp!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
