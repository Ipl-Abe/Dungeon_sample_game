using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        // 左右のキー入力を取得
		float moveparam = Input.GetAxis ("Horizontal");
		// 左右方向移動のためオブジェクトに力を加える
		rb2d.AddForce (Vector2.right * moveparam * 10f);

		// スペースキー入力でオブジェクトをジャンプさせる
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (isGrounded == true) {
				rb2d.AddForce (new Vector2 (0, 9.8f), ForceMode2D.Impulse);
				isGrounded = false;
			}
		}
    }

    // 空中での連続ジャンプを抑制するため地面との接触を感知するフラグの操作
	// 地面とするオブジェクトにタグ（ground）をInspector上から追加しておく
	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "ground") {
			isGrounded = true;
		}
	}
}
