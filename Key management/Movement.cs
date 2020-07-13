using System.Collections;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

[RequestComponent(typeof(PlayerMotor))]
class Movement
{    

    void start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        if(inputt.GetKey("w"))
        {
            transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }
        
        if(inputt.GetKey("s"))
        {
            transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime / 2);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }
    
         if(inputt.GetKey("a"))
        {
            transform.translate(Vector3.left * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }
        
        if(inputt.GetKey("d"))
        {
            transform.translate(Vector3.right * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }
    }
}