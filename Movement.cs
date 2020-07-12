
// Start Position
Function Start()
{
    transform.position = (1,1,1)
}

// Incluted Keys
Function Update()
{
    // Character Movement
    if(inputt.GetKey("w"))
    {
        transform.translate(Vector3.ahead * SpeedPlayer * Time.deltaTime);
    }
    
    if(inputt.GetKey("s"))
    {
        transform.translate(Vector3.back * SpeedPlayer * Time.deltaTime);
    }
    
    if(inputt.GetKey("a"))
    {
        transform.translate(Vector3.left * SpeedPlayer * Time.deltaTime);
    }
    
    if(inputt.GetKey("d"))
    {
        transform.translate(Vector3.right * SpeedPlayer * Time.deltaTime);
    }
    
    // fight
    if(inputt.GetKey(""))
}
