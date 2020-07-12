using System.Runtime.CompilerServices;
using System.Collections;

class BillBoard
{
    void LateUpdate()
    {
        transform.LookAt(Transform.position + cam.forward);
    }
}