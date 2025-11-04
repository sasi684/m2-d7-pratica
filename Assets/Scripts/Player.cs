using UnityEngine;

public class Player
{
    public string nome;
    private int punteggio;

    public void IncrementaPunteggio(int incremento)
    {
        punteggio += incremento;
    }

    public int GetPunteggio()
    {
        return punteggio;
    }

    public void SetPunteggio(int punteggioNew)
    {
        if(punteggioNew < 0)
        {
            punteggio = 0;
            Debug.LogWarning("Il punteggio non può essere negativo");
        }
        else
        {
            punteggio = punteggioNew;
        }
    }

    public bool IsVincitore()
    {
        if (punteggio >= 100)
            return true;

        return false;
    }

    public void AttaccaNemico(Enemy nemico, int danno)
    {
        nemico.SubisciDanno(danno);
        Debug.Log($"Il giocatore {nome} ha fatto {danno} danni al nemico {nemico.nome}");
    }
}
