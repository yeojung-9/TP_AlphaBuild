using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction_Gimmick : GimmickTrigger
{

    public LayerMask DetectionLayer; // 중돌 감지 레이어

    public RectTransform InteractionImge; // UI 이미지의 RectTransform
    Camera mainCamera; // 메인 카메라

    public Transform targetObject; // 3D 물체의 Transform

    private void Start()
    {
        mainCamera = Camera.main;
        InteractionImge.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (((1 << other.gameObject.layer) & DetectionLayer) != 0)
        {
            InteractionImge.gameObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (((1 << other.gameObject.layer) & DetectionLayer) != 0 )
        {
            // 3D 물체의 위치를 화면 좌표로 변환
            Vector3 screenPos = mainCamera.WorldToScreenPoint(targetObject.position);

            // 화면 좌표를 UI 좌표로 변환
            InteractionImge.position = screenPos;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (((1 << other.gameObject.layer) & DetectionLayer) != 0)
        {
            InteractionImge.gameObject.SetActive(false);
        }
    }
}
