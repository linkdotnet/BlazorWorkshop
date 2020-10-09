namespace LinkDotNet.BlazorWorkshop.Client.Shared
{
    public partial class Counter
    {
        private int _currentCount;

        private void IncrementCount()
        {
            _currentCount++;
        }

        public void Reset()
        {
        }
    }
}