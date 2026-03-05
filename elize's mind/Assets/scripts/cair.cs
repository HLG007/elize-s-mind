using UnityEngine;
using System.Collections;

public class cair : MonoBehaviour

{
    bool estaMovendo = false; //Atribuo a variavel 'estaMovendo' o Valor de falso, para evitar que o objeto caia duas vezes(se clicar no botão de menu de opções mais q uma vez)

    public void Descer() //Crio uma função chamada descer
    {
        if (!estaMovendo) //Se o objeto NÃO esta se movendo
            StartCoroutine(Mover(-1)); //Inicia a CoRoutine chamada Mover, onde o valor passado é -1, para o X ser negativo e ir para baixo
    }

    public void Subir() //Crio uma função chamada subir
    {
        if (!estaMovendo) //Se o objeto não esta se movendo
            StartCoroutine(Mover(1)); //Inicia a coroutine chamada mover, onde passamos o valor 1 para indicar que queremos que ele va para cima.
    }

    IEnumerator Mover(int direcao) //Crio uma função do tipo IEnumerator, que é uma função que pode ser pausada e retomada,
                                   //mais detalhamente, é uma função que é executada tipo um loop, mas ele não pausa o resto do codigo
    {
        estaMovendo = true;  //A variavel estaMovendo vira verdadeira, já expliquei o pq

        for (int i = 0; i < 50; i++) //Inicia um loop for, onde o valor I = 0, a cada loop aumenta o I por 1, onde se I for maior que 50, o loop para
        {
            transform.position += new Vector3(0, direcao * 25, 0); //TransformPosition (posição do objeto) aumenta por um vector 3
                                                                   //(3 dimensões, pq com 2 deu erro por algum motivo) e multiplico a direção (1 ou -1) por 25 cada loop, fazendo
                                                                   //objeto se mover 25 unidades cada loop no valor Y

            yield return new WaitForSeconds(0.005f); //Esperamos uma quantia de tempo pequena para o movimento ser suave, se isso n existe o movimento seria instantaneo e feio.
        }

        estaMovendo = false; //A variavel vira falsa, possibilidando a movimentação do objeto dnv
    }
}

