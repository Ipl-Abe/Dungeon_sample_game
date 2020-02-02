using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pinky_walk : MonoBehaviour
{
    Animator animator;
    // 速度
	public Vector2 SPEED = new Vector2(0.05f, 0.05f);
    // Start is called before the first frame update
    float Yspeed;


    // 目的地に着いたかどうか
    private bool isReachTargetPosition;
    // 目的地
    private Vector3 targetPosition;

    // x軸 下限
    public const float X_MIN_MOVE_RANGE = -4f;
    // x軸 上限
    public const float X_MAX_MOVE_RANGE = 4f;
    // y軸 下限
    public const float Y_MIN_MOVE_RANGE = -2f;
    // y軸 上限
    public const float Y_MAX_MOVE_RANGE = 2f;
    // 移動スピード
    // public const float SPEED = 0.03f;


    //private int minute;
    private float seconds;
    // private float oldSeconds;
    // private Text timerText;

    void Start()
    {
        animator = GetComponent<Animator>();
        this.isReachTargetPosition = false;
        decideTargetPotision();
        animator.SetBool("IsRunning", true);
        //minute = 0;
        seconds = 0f;
        //oldSeconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Collision");
        // start, end, color, duration, depthTest
        // if(seconds >=60f){
        //     minute++;
        //     seconds = seconds -60;
        // }

        decideTargetPotision();
 
        // 現在地から目的地までSPEEDの速度で移動する
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, SPEED.x);
        // 目的地についたらisReachTargetPositionをtrueにする
        if(transform.position == targetPosition){
            isReachTargetPosition = true;
        }
       // Move();
    }
    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Collision");
        if(other.gameObject.tag == "Walls"){
            //Time.timeScale = 0f;
            //targetPosition = new Vector3(Random.Range(X_MIN_MOVE_RANGE, X_MAX_MOVE_RANGE), Random.Range(Y_MIN_MOVE_RANGE, Y_MAX_MOVE_RANGE), 0);
            isReachTargetPosition = true;
            //targetPosition = transform.position;
        }
    }
    //	// 移動関数
	//void Move(){
	//	//現在位置をPositionに代入
	//	Vector2 Position = transform.position;
    //    Yspeed = SPEED.y;
    //    if(Input.GetKey(KeyCode.S)){
    //        Yspeed = 0;
    //        animator.SetBool("IsRunning", false);
    //    }
    //    else{
    //        animator.SetBool("IsRunning", true);
    //    }
	//	Position.y -= Yspeed;
	//	transform.position = Position;
	//}

    // 目的地を設定する
    private void decideTargetPotision(){
        // まだ目的地についてなかったら（移動中なら）目的地を変えない
        //seconds += Time.deltaTime;
        //if(seconds < 20f) {
          //   Debug.DrawLine(transform.position, targetPosition, Color.white, 2.5f);
            if(!isReachTargetPosition ){
                return;
            }
        //}

        //seconds = 0f;
        animator.SetBool("IsRunning", false);
        seconds += Time.deltaTime;
        targetPosition = new Vector3(transform.position.x, transform.position.y, 0);
        // if(seconds > 3){
        //     seconds = 0f; 
        // }
        Debug.Log(seconds);
        if(seconds > 4f){
        // 目的地に着いていたら目的地を再設定する
            targetPosition = new Vector3(Random.Range(X_MIN_MOVE_RANGE, X_MAX_MOVE_RANGE), Random.Range(Y_MIN_MOVE_RANGE, Y_MAX_MOVE_RANGE), 0);
            isReachTargetPosition = false;
            animator.SetBool("IsRunning", true);
            seconds = 0f;
        }
    }

}

// TODO : targetPositionを更新するだけの関数を準備
// ディテイ等はその関数の外側で行う．



