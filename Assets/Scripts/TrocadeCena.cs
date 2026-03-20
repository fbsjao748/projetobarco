using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string nomeDaCena;

    //Metodo para corrotina Abrir
    public void Procurar()
    {
       StartCoroutine(Abrir());
    }
    
    //Metodo para fechar a aplicação
    public void Exit()
    {
       StartCoroutine(Exits());

       //essa linha fecha o play após a morte do jogador
       #if UNITY_EDITOR
           UnityEditor.EditorApplication.isPlaying = false;
       #endif
    }
    
    //Metodo para abrir a variavel especifica
    private IEnumerator Abrir()
    {
       yield return new WaitForSeconds(1.4f);
       SceneManager.LoadScene(nomeDaCena);
    }

    //Metodo para sair com tempo
    public IEnumerator Exits()
    {
       yield return new WaitForSeconds(1.4f);
       Application.Quit();
    }

}
