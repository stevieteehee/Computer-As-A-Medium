using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            if(mana >= 10)
            {
                mana -= 10;
                animator.SetTrigger("Cast");

            }
        }

        manaText.text = "Mana: " + mana;
    }
}
