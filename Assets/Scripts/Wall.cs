using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite;
    public int hp = 4;
    public AudioClip cutSound1;
    public AudioClip cutSound2;

    private SpriteRenderer spriteRenderer;

	void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();	
	}
	
    public void DamageWall(int loss)
    {
        SoundManager.instance.RandomiseSfx(cutSound1, cutSound2);
        spriteRenderer.sprite = dmgSprite;
        hp -= loss;
        if (hp <= 0)
            gameObject.SetActive(false);
    }
}
