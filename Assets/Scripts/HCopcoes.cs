using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class HCopcoes : MonoBehaviour
{
    public static int CasaAtual;
    
    public static HCquestao QuestaoAtual;
    public static string Selecao;
    
    [SerializeField]
    public static TMP_Text OpcaoA;
    public static TMP_Text OpcaoB;
    public static TMP_Text OpcaoC;
    public static TMP_Text OpcaoD;

    // Start is called before the first frame update
    void Start()
    {
        OpcaoA = GameObject.Find("OpcaoA").GetComponent<TMP_Text>();
        OpcaoA.text = QuestaoAtual.OpcaoA;
        OpcaoB = GameObject.Find("OpcaoB").GetComponent<TMP_Text>();
        OpcaoB.text = QuestaoAtual.OpcaoB;
        OpcaoC = GameObject.Find("OpcaoC").GetComponent<TMP_Text>();
        OpcaoC.text = QuestaoAtual.OpcaoC;
        OpcaoD = GameObject.Find("OpcaoD").GetComponent<TMP_Text>();
        OpcaoD.text = QuestaoAtual.OpcaoD;
    }

    public static void CertoOuErrado(string Botao)
    {
        switch (Botao)
        {
            case "A":
                Selecao = QuestaoAtual.OpcaoA;
                break;
            case "B":
                Selecao = QuestaoAtual.OpcaoB;
                break;
            case "C":
                Selecao = QuestaoAtual.OpcaoC;
                break;
            case "D":
                Selecao = QuestaoAtual.OpcaoD;
                break;
        }
        
        if (Selecao == QuestaoAtual.Resposta)
        {
            SceneManager.LoadScene("HoraDoCuidadoCerto");
            HCrespostaCerta.Questao = QuestaoAtual;
            HCrespostaCerta.CasaAtual = CasaAtual;
        }
        else
        {
            SceneManager.LoadScene("HoraDoCuidadoErrado");
            HCrespostaErrada.Questao = QuestaoAtual;
            HCrespostaErrada.CasaAtual = CasaAtual;
        }
        
    }

    public static void Voltar()
    {
        SceneManager.LoadScene("HoraDoCuidadoPergunta");
        HCpergunta.QuestaoAtual = QuestaoAtual;
        HCpergunta.CasaAtual = CasaAtual;
    }
}
