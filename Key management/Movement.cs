using System.Collections;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

class Movement
{    
    void Update()
    {
        if(inputt.GetKey("w"))
        {
            transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
        }
        
        if(inputt.GetKey("s"))
        {
            transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime / 2);
            Play = ("WalkingSounds");
        }
    
         if(inputt.GetKey("a"))
        {
            transform.translate(Vector3.left * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
        }
        
        if(inputt.GetKey("d"))
        {
            transform.translate(Vector3.right * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
        }
    }
}