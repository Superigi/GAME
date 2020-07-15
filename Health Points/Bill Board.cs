using System.Runtime.CompilerServices;
using System.Collections;

class BillBoard
{
    // Health bar
    void LateUpdate()
    {
        transform.LookAt(Transform.position + cam.forward);
    }
}