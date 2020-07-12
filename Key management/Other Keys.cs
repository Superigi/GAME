using System.Collections;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

class OtherKeys
{
    int CanvasPoint = 0;

    Function Update()
    {
        if(inputt.GetKey("Escape"))
        {
            if(CanvasPiont => 1)
            {
                CanvasInventory = false;
                CanvasQuest = false;
            }
            else
            {
                CanvasMenuQuit = true;
            }   
        }

        if(Inputt.GetKey("Tab"))
        {
            CanvasInventory = true;
            CanvasPoint =+ 1;
        }

        if(Inputt.GetKey("c"))
        {
            CanvasQuest = true;
            CanvasPoint =+ 1;
        }
    }
}