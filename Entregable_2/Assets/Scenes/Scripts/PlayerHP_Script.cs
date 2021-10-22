using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP_Script : MonoBehaviour
{
    //Game Over
    [SerializeField]private bool isGameOver;
    // Vida del Player
    private int playerHP = 150;
    // Daño inflingido por al Player
    public int Damage = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"PlayerHP: = {playerHP - Damage}");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            if(playerHP <= 0)
            {
                Debug.Log($"Te has quedado sin vida... GAME OVER");
            }else if (playerHP <= 30)
            {
                Debug.Log($"¡¡¡Tienes poca vida!!!");
            }
            else
            {
                Debug.Log($"Vas bien: tienes {playerHP - Damage} puntos de vida.");
            }
        }
        else
        {
            Debug.Log($"GAME OVER");
        }
    }
}
