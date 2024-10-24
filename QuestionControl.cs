using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADR_Cursus
{
    public abstract class QuestionControl : UserControl
    {
        public abstract bool HasAnswer { get; }
    }
}
