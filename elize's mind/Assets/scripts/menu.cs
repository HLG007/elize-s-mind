using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importamos a funcionalidade de cenas para conseguir mexer em cenas

public class menu : MonoBehaviour
{

    public cair objetoQueVaiCair; //Crio uma variavel publica com o nome cair, onde eu arrasto o objeto que vai cair(menu opções)

    public void Jogar() //Declaro uma função jogar
    {
        SceneManager.LoadScene("jogo"); //Quando chamar o função jogar, a cena muda para a do jogo.
    }

    public void DescerBotao() //Declaro uma função chamda descerbotão
    {
        objetoQueVaiCair.Descer(); //Faço o objeto chamar a função descer(que defini na script cair, nem eu sei como fiz isso)
    }

    public void SubirBotao() //Declaro uma função chamada subirbotão
    {
        objetoQueVaiCair.Subir(); //Faço chamar a função descer no objetoquevaicair
    }

    public void Sair() //Declaro uma função chamada sair
    {
        Application.Quit(); //Fecha o aplicativo
    }


}
