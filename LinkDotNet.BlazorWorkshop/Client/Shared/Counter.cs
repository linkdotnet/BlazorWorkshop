using Microsoft.AspNetCore.Components;

namespace LinkDotNet.BlazorWorkshop.Client.Shared
{
    public partial class Counter
    {
        [Parameter]
        public int CurrentCount { get; set; }

        private void IncrementCount()
        {
            CurrentCount++;
        }

        public void Reset()
        {
        }
    }
}