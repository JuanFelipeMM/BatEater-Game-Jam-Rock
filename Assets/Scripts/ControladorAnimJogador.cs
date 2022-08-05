using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAnimJogador : MonoBehaviour
{
    public Animator playerAnimator;
    
    public void playAnimation(string animacao)
    {
        playerAnimator.Play(animacao);
    }
}
