using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ����Ƽ������ �⺻������ ���� �̵��� �� ������Ʈ�� �������� �ʰ� �ϴ� ����� �ִ�
// ������ ������ ����Ǿ �����Ǹ� �ȵǴ� ���Ӹ޴����� �̸� Ȱ���Ѵ�
// ������ �� ������Ʈ�� Ÿ��Ʋ�� �����Ű�� Ÿ��Ʋ�� ���ƿö����� ���Ӹ޴����� ����Ǹ� ������ ����
// �׷��� �ϴ� ���� ������ �� �ӽ� ���� ���� �����Ǹ� �ȵǴ� ������Ʈ���� �̸� �ε��� �� �����Ѵ�
public class FirstScene : MonoBehaviour
{
    [SerializeField]
    private string nextScene;
    void Start()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

}
