using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconEx3;

 abstract class SystemError
{
    public abstract string ErrorMessage();
}

class EngineFailureError : SystemError
{

    public override string ErrorMessage()
    {
        return "Motorfel: Kontrollera motorstatus!";
    }
}class BrakeFailureError  : SystemError
{

    public override string ErrorMessage()
    {
        return "Bromsfel: Fordonet är osäkert att köra!";
    }
}class TransmissionError : SystemError
{

    public override string ErrorMessage()
    {
        return "Växellådsproblem: Reparation krävs!";
    }
}


