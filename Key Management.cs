using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

Private int fight = 0;

// Start Position
Function Start()
{
    Return0;
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

        fight =+ 1;
        
        if(fight == 1)
        {
            PlayAnimation = ("WeaponExtended");
        }
        else
        {
            fight =+ 1;
        }

        if(fight == 2)
        {
            fight =- 2;
        }
        else
        {
            
        }

        if(fight == 1)
        {
            if(Inputt.GetKey("Control"))
            {
                // Basis attacks
                if(inputt.GetKey("W"))
                {
                    if(Weapon.Vector == Vector)
                    {
                        PlayAnimation = ("FailedFrontAttack");
                        Play = ("MetalSound");
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
                        Play = ("MetalSound");
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
                        Play = ("MetalSound");
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

                //Block
                if(inputt.GetKey("Shift"))
                {
                    PlayAnimation = ("Block");
                    Player.Def = 1000000000000;
                }
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
