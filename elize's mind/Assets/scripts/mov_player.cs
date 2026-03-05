using UnityEngine;
using UnityEngine.InputSystem;

public class mov_player : MonoBehaviour
{
    private Vector2 movement; //Criamos um vector 2(algo que contem o valor X e Y) e damos o nome dele de movement
    [SerializeField] private float speed = 5f; //Criamos uma variavel de velocidade, onde deixamos como 5(para ela andar 5x mais rapido que o normal)
                                               //ela é private(pq vi q é bom ser assim) e tem o Serialize Field para consiguir alterir isso no menu da unity

    private Rigidbody2D rb; //Criei uma variavel chamada 'rb', para obter o Rigidbody2D do objeto player, para ser possivel mexer ele

    private void Awake() //O 'awake' serve para ser chamado antes do jogo começar, serve para inicializar variaveis
    {
        rb = GetComponent<Rigidbody2D>(); //Aqui iniciamos o componente Rigidbody2D do objeto player, para ser possivel mexer ele

    }

    private void OnMovement(InputValue value) //Quando o jogador se mexer, vai mandar o valor 'InputValue' (do input system*) para a variavel 'value'
    {
        movement = value.Get<Vector2>(); //Aqui armazenamos o valor do movimento do jogador(value.get) e transformamos ele em um vector2(X,Y) armazenado na variavel movement

    }

    private void FixedUpdate() //FixedUptade é chamado muito frequentemente, e onde acontece o movimento.
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); //Aqui movemos o jogador no rigidbody(rb) usando a função movePosition, onde usamos a
                                                                               //posição atual dele (rb.position) + o valor do movimento(que recebemos do input system, sendo
                                                                               //x +- (y tbm) e quando na diagonal é 0.7 em ambas as direções, multiplicando pela velocidade
                                                                               //e multiplicamos pelo Time.fixedDeltaTime para q o movimento aconteça a cada um periodo de tempo,
                                                                               //não a cada frame(pois jogadores podem jogar em framerate diferente.


    }
}
