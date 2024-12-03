namespace DayCycleSystem
{
    public class MovementController : IObserver
    {
        private Movement _sun;
        private IObserverable _observerable;

        public MovementController(Movement sun, IObserverable observerable)
        {
            _sun = sun;
            _observerable = observerable;

            _observerable.RegisterObserver(this);
        }

        public void UpdateObserver(float cycleFraction)
        {
            _sun.MoveAcrossSky(-360 * cycleFraction);
        }
    }
}