using UnityEngine;

public class StaticPropertiesAndMethods : MonoBehaviour
{

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


        // �}�ҳs��
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Application.OpenURL("https://unity.com/");
        }
    }

    private void Update()
    {
        // �O�_���U����
        bool space = Input.GetKeyDown(KeyCode.Space);

        // �O�_��J���N��
        print("��J�����䬰�G" + Input.anyKey);


        // �C���g�L�ɶ�
        print("�g�L�ɶ��G" + Time.frameCount);
    }
}
