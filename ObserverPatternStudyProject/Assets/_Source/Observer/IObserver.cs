using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DayCycleSystem
{
    public interface IObserver
    {
        public void UpdateObserver(float cycleFraction);
    }
}