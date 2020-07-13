using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.ExceptionServices;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

[RequestComponent(typeof(NewMeshAgent))]
class PlayerMotor
{
    NewMeshAgent agent;
    void start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveToPoint (Vector3 point)
    {
        agent.setDestination(point);
    }
}