using TunnelChooseSystem.Data;
using UnityEngine;

namespace TunnelChooseSystem
{
    public class TunnelChooser : MonoBehaviour
    {
        [SerializeField] private TunnelData[] tunelDatas;

        [SerializeField] private CanvasGroup darkScreen;

        private void Awake()
        {
            foreach (var data in tunelDatas)
            {
                data.button.onClick.AddListener(()
                    => StartTunnelTransition(data.pointTeleport.position));
            }
        }

        private void StartTunnelTransition(Vector3 targetPosition)
        {
            ClearButtonData();
            
            //тут треба зробити переход на іншу позицию
        }

        private void ClearButtonData()
        {
            foreach (var data in tunelDatas)
            {
                data.button.onClick.RemoveAllListeners();
            }
        }
    }
}