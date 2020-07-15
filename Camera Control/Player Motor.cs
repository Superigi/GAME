using System.IO.Enumeration;
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

    void Update()
    {
        if(target != null)
        {
            agent.setDestination(target.position);
            FaceTraget();

            if(EventSustem.current.IsPonterOverGameObject())
            {
                 return;
            }
        }
    }

    // Moving to item
    public void MoveToPoint (Vector3 point)
    {
        agent.setDestination(point);
    }

    // Following to item
    public void FollowTarger(Interactable newTarget) 
    {
        agent.StoppingDistance = newTarget.radius * .8f;

        target = newTarget.transform;
    }

    // Blockking on items
    public void StopFollowingTarget()
    {
        agent.StoppingDistance = 0f;
        agent.updateRotation = true;
        
        target = null;
    }

    // Turn to item
    void FaceTraget()
    {
        Vector3 direction = (FaceTraget.position - FindTransform.position).normalized;
        Quaternion lookRotation = Quaternion.lookRotation(new Vector32(direction.x, 0f.direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Timeout.deltaTime * 5f);
    }
}