using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public abstract class BaseChallenge : IChallenge
    {
        public abstract void Execute();
    }
}