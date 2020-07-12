using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

// Start Position
Function Start()
{
    transform.position = (1,1,1)
}

// Keys Management
Function Update()
{
    // Canvas Management
    if(inputt.GetKey("Escape"))
    {
        CanvasMenuQuit = true;
    }
    
    // fight
    if(inputt.GetKey("Space"))
    {
        PlayAnimation = ("WeaponExtended");

        if(Inputt.GetKey("Control"))
        {
            // Basis attacks
            if(inputt.GetKey("W"))
            {
                if(Weapon.Vector == Vector)
                {
                    PlayAnimation = ("FailedFrontAttack");
                    PLay = ("MetalSound");
                }
                else
                {
                    PlayAnimation = ("FrontalAttack");
                    Transform.translate(Vector3.ahead * 5);
                }
            }

            if(inputt.GetKey("a"))
            {
                if(Weapon.Vector == Vector)
                {
                    PlayAnimation = ("FailedLeftAttack");
                    PLay = ("MetalSound");
                }
                else
                {
                    PlayAnimation = ("LeftAttack");
                }
            }

            if(inputt.GetKey("d"))
            {
                if(Weapon.Vector == Vector)
                {
                    PlayAnimation = ("FailedRightAttack");
                    PLay = ("MetalSound");
                }
                else
                {
                    PlayAnimation = ("RightAttack");
                }
            }
            if(Inputt.GetKey("s"))
            {
                PlayAnimation = ("Dodge");
                transform.translate(BitVector32.back * 5);
            }

        }
        else
        {
            // Character Movement in combat
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
    else
    {
    
        // Character Movement out of combat
        
        if(InputGetKKey("Shift"))
        {

            // Crouch

            PlayAnimation = ("Crouch");


            if(inputt.GetKey("w"))
            {
                transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime / 2);
            } 
    
            if(inputt.GetKey("s"))
            {
                transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime / 4);
            }
    
            if(inputt.GetKey("a"))
            { 
                transform.translate(Vector3.left * SpeedPlayer * Time.deltaTime / 2);
            }
    
            if(inputt.GetKey("d"))
            {
                transform.translate(Vector3.right * SpeedPlayer * Time.deltaTime / 2);
            } 
        }
        else
        {

            // Normal gait

            if(inputt.GetKey("w"))
            {
                transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime);
                Play = ("WalkingSounds");
            } 
    
            if(inputt.GetKey("s"))
            {
                transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime);
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

    

}
