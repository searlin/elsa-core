using Flowsharp.Activities;

namespace Flowsharp.Models
{
    public class SourceEndpoint : Endpoint
    {
        public SourceEndpoint()
        {
        }

        public SourceEndpoint(IActivity activity, string name = null) : base(activity)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}