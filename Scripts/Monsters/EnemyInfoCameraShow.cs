using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfoCameraShow : MonoBehaviour
{
    
    private enum Mode
    {
        LookAt,
        LookAtInverted, //* ���� ���� ����
        CameraForward,
        CameraForwardInverted, //* ���� ���� ����
    }
    [SerializeField] private Transform csamera;
    [SerializeField] private Mode mode;

    private void Start()
    {
        csamera = GameObject.Find("PlayerPrefeb").transform.GetChild(1).GetChild(0).GetChild(0);
    }
    private void LateUpdate()
    {
        switch (mode)
        {
            case Mode.LookAt:
                transform.LookAt(csamera);
                break;
            case Mode.LookAtInverted:
                //* ī�޶� ������ �˾Ƴ��� �� ���� ��ŭ �����༭ ������Ű��
                Vector3 dirFromCamera = transform.position - csamera.position;
                transform.LookAt(transform.position + dirFromCamera);
                break;
            case Mode.CameraForward:
                //* ī�޶� �������� Z�� (�յ�)�� �ٲ��ֱ�
                transform.forward = csamera.forward;
                break;
            case Mode.CameraForwardInverted:
                //* ī�޶� �������� Z�� (�յ�)�� �ٲ��ְ� ������Ű��
                transform.forward = -csamera.forward;
                break;
            default:

                break;
        }
    }
}
