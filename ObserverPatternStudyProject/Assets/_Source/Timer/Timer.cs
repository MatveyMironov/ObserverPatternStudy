using System.Collections.Generic;
using UnityEngine;

namespace DayCycleSystem
{
    public class Timer : MonoBehaviour, IObserverable
    {
        [SerializeField] private float cycleLength;

        private float _currentTime;
        private float _cycleFraction;

        private List<IObserver> _observers = new List<IObserver>();

        private void Update()
        {
            CountCycle();
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.UpdateObserver(_cycleFraction);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        private void CountCycle()
        {
            _currentTime += Time.deltaTime;
            if (_currentTime >= cycleLength)
            {
                _currentTime -= cycleLength;
            }
            _cycleFraction = _currentTime / cycleLength;
            Debug.Log($"Current time is {_currentTime}s which is {_cycleFraction} of the {cycleLength}s sycle");
        }
    }
}