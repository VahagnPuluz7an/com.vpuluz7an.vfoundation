using UnityEngine;

namespace VFoundation.Tutorial
{
    public class PointPointer : MonoBehaviour
    {
        [SerializeField] private PointerSettings settings;

        private void Awake()
        {
            Instantiate(settings.PointerPrefab, transform.position,transform.rotation,transform);
        }
    }
}
