using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
public class Interacable
{
    public float radius = 3f;
    public transform interactionTransform;

    bool isFocus = false;
    Transform Player;

    bool hasInteracted = false;

    // Debug Log
    public virtual void Interact()
    {
        Debug.Log("Interact with" + transform.name);
    }

    //Interacn on item
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

    // Focus on item
    public void OnFocused (Transform playerTransform)
    {
        isFocus focus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    // Defocus on item
    public void OnDefocuset ()
    {
        isFocus = false;
        Player = null;
        hasInteracted = false;
    }
    
    // Drawing color on the edges of items
    void OnDrawGizmosSelected()
    {
        if(interactionTransform == null)
        {
            interactionTransform = transform;
        }

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}