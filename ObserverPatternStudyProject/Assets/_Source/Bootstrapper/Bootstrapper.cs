using DayCycleSystem;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Timer timer;
        [SerializeField] private Movement sun;
        [SerializeField] private List<ColorChange> colorChanges;

        private void Awake()
        {
            MovementController sunController = new(sun, timer);

            foreach (var colorChange in colorChanges)
            {
                ColorChangeController colorChangeController = new(colorChange, timer);
            }
        }
    }
}