using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class StaticPropertiesAndMethods : MonoBehaviour
{
    public KeyCode a;

    private void Start()
    {

        // 所有攝影機數量
        print("攝影機總數：" + Camera.allCamerasCount);

        // 2D重力大小
        print("2D的重力大小：" + Physics2D.gravity);
        // 2D重力大小設定
        Physics2D.gravity = new Vector2(0, -20);

        // 圓周率
        print("圓周率：" + Mathf.PI);

        // 時間大小設定(慢動作)
        Time.captureDeltaTime = 0.5f;

        // 去小數點


        // 取得兩點間的距離
        
    }

    private void Update()
    {
        // 是否按下按鍵
        if (Input.GetKey("KeyCode"))
        {
        // 是否輸入任意鍵
        print("輸入的按鍵為：" + Input.anyKey);
        }

        // 遊戲經過時間
      //  print("經過時間：" + Time.frameCount);
    }
}
