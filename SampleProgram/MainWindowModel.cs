using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    public class MainWindowModel
    {
        public string ProgramTitle => $"Sample Test V{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";


    }
}
