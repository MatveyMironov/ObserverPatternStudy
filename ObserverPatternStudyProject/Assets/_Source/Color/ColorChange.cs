using UnityEngine;

namespace DayCycleSystem
{
    public class ColorChange : MonoBehaviour
    {
        private Renderer[] renderers;

        [Space]
        [SerializeField] private Gradient gradient;

        private void Awake()
        {
            renderers = GetComponentsInChildren<Renderer>();
        }

        public void ChangeColor(float cycleFraction)
        {
            foreach (var renderer in renderers)
            {
                renderer.material.color = gradient.Evaluate(cycleFraction);
            }
        }
    }
}