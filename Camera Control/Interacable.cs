
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
class Interacable
{
    public float radius = 3f;
    public transform interactionTransform;

    bool isFocus = false;
    Transform Player;

    bool hasInteracted = false;

    public virtual void Interact()
    {
        Debug.Log("Interact with" + transform.name);
    }

    void update()
    {
        if(isFocus && !hasInteracted)
        {
            float distance = Vector3.Distacne(Player.position, interactionTransform.position);
            if(distance <= radius)
            {
                Interact();
                bool hasInteracted = true;
            }
        }
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus focus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocuset ()
    {
        isFocus = false;
        Player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}