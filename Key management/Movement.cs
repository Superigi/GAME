using System.Net;
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

    public Interactable focus;

    void start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    // Normal moving
    void Update()
    {
        if(inputt.GetKey("w"))
        {
            transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                Interactable Interactable = hit.colider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }

                RemoveFocus();
            }
        }
        
        if(inputt.GetKey("s"))
        {
            transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime / 2);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                Interactable Interactable = hit.colider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }

                RemoveFocus();
            }
        }
    
         if(inputt.GetKey("a"))
        {
            transform.translate(Vector3.left * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                Interactable Interactable = hit.colider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }

                RemoveFocus();
            }
        }
        
        if(inputt.GetKey("d"))
        {
            transform.translate(Vector3.right * SpeedPlayer * Time.deltaTime);
            Play = ("WalkingSounds");
            PlayAnimation = ("Walking");
            if(Psysics.Raycast(ray, out hit, 100, MovementMask))
            {
                Interactable Interactable = hit.colider.GetComponent<Interactable>();
                if(interactable != null)
                {
                    SetFocus(interactable);
                }
            }
        }
    }

    // Focus on items
    void SetFocus (Interactable newFocus)
    {
        if(newFocus != focus)
        {
            if(focus != null)
            {
                focus.OnDefocused();
            }        
            Focus = newfocus;
            motor.FollowTarget(newFocus);
        }

        newFocus.OnFocused(transform);
    }

    // Remove focus
    void RemoveFocus()
    {
        if(focus != null)
        {
            focus.OnDefocused(); 
        }
        focus = null;
        mator.StopFollowingTarget();
    }
}