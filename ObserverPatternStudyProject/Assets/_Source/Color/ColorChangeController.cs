using UnityEngine;

namespace DayCycleSystem
{
    public class ColorChangeController : IObserver
    {
        private ColorChange _sky;
        private IObserverable _observerable;

        public ColorChangeController(ColorChange sky, IObserverable observerable)
        {
            _sky = sky;
            _observerable = observerable;

            _observerable.RegisterObserver(this);
        }

        public void UpdateObserver(float cycleFraction)
        {
            _sky.ChangeColor(cycleFraction);
        }
    }
}