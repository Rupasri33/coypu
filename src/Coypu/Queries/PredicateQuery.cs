using System;

namespace Coypu.Queries
{
    public abstract class PredicateQuery : Query<bool>
    {
        public Options Options { get; }
        public DriverScope Scope { get; private set; }

        protected PredicateQuery(Options options)
        {
            Options = options;
        }

        public abstract bool Predicate();

        public bool Run()
        {
            return Predicate();
        }

        public object ExpectedResult => true;
    }
}