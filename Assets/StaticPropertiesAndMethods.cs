using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class StaticPropertiesAndMethods : MonoBehaviour
{
    public KeyCode a;

    private void Start()
    {

        // �Ҧ���v���ƶq
        print("��v���`�ơG" + Camera.allCamerasCount);

        // 2D���O�j�p
        print("2D�����O�j�p�G" + Physics2D.gravity);
        // 2D���O�j�p�]�w
        Physics2D.gravity = new Vector2(0, -20);

        // ��P�v
        print("��P�v�G" + Mathf.PI);

        // �ɶ��j�p�]�w(�C�ʧ@)
        Time.captureDeltaTime = 0.5f;

        // �h�p���I


        // ���o���I�����Z��
        
    }

    private void Update()
    {
        // �O�_���U����
        if (Input.GetKey("KeyCode"))
        {
        // �O�_��J���N��
        print("��J�����䬰�G" + Input.anyKey);
        }

        // �C���g�L�ɶ�
      //  print("�g�L�ɶ��G" + Time.frameCount);
    }
}
