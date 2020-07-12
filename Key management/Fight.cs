using System.Collections;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

class Fight
{

    int fight = 0;
    int Air = AirSkill;
    int Water = WaterSkill;
    int Fire = FireSkill;
    int Ground = GroundSkill;
    int Magic = 0;


    void Update()
    {
        if((AirSkill <= 1) && (WaterSkill <= 1) && (FireSkill <= 1) && (GroundSkill <= 1))
        {
            magic =+ 1;
        }

        
        // Fight
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
                Return0;
            }

            if(fight == 1)
            {
                if(Magic == 1)
                {
                    if(Inputt.GetKey("Control"))
                    {

                    
                        if(AirSkill <= 1)
                            {     
                            // Basis magic air attacks
                            if(inputt.GetKey("w"))
                            { 
                                PlayAnimation = ("FrontalAirAttack");
                                Transform.translate(Vector3.ahead * 5);                      
                            }
                             if(inputt.GetKey("a"))
                            {
                                PlayAnimation = ("LeftAirAttack");
                            }
                            if(inputt.GetKey("d"))
                            {
                                PlayAnimation = ("RightAitAttack"); 
                            }
                            if(Inputt.GetKey("s"))
                            {
                                PlayAnimation = ("AirDodge");
                                transform.translate(Vector32.back * 5);
                            }
                        }
                        if(WaterSkill <= 1)
                        {
                            // Basis magic water attacks
                            if(inputt.GetKey("w"))
                            { 
                                PlayAnimation = ("FrontalWaterAttack");
                                Transform.translate(Vector3.ahead * 5);                      
                            }

                            if(inputt.GetKey("a"))
                            {
                                PlayAnimation = ("LeftWaterAttack");
                            }

                            if(inputt.GetKey("d"))
                            {
                                PlayAnimation = ("RightWaterAttack");
                            }
                            if(Inputt.GetKey("s"))
                            {
                                PlayAnimation = ("WaterDodge");
                                transform.translate(Vector32.back * 5);
                            }
                        }
                        if(FireSkill <= 1)
                        {
                            // Basis magic fire attacks
                            if(inputt.GetKey("w"))
                            { 
                                PlayAnimation = ("FrontalFireAttack");
                                Transform.translate(Vector3.ahead * 5);                      
                            }

                            if(inputt.GetKey("a"))
                            {
                                PlayAnimation = ("LeftFireAttack");
                            }

                            if(inputt.GetKey("d"))
                            {
                                PlayAnimation = ("RightFireAttack");                  
                            }
                            if(Inputt.GetKey("s"))
                            {
                                PlayAnimation = ("FireDodge");
                                transform.translate(Vector32.back * 5);
                            }
                        }

                        if(GroundSkill <= 1)
                        {
                            // Basis magic ground attacks
                            if(inputt.GetKey("w"))
                            { 
                                PlayAnimation = ("FrontalAirAttack");
                                Transform.translate(Vector3.ahead * 5);                      
                            }

                            if(inputt.GetKey("a"))
                            {
                                PlayAnimation = ("LeftAirAttack");
                            }

                            if(inputt.GetKey("d"))
                            {
                                PlayAnimation = ("RightAttack");
                        
                            }
                            if(Inputt.GetKey("s"))
                            {
                                PlayAnimation = ("Dodge");
                                transform.translate(Vector32.back * 5);
                            }
                        } 
                    }   
                }
                else
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
                }
            }
        }
    }
}