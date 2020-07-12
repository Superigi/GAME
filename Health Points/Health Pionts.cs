using System.Collections;

class HealthPoints
{
    int MaxHealth = 100 + 10 * CurrentLevel;
    int CurrentHealth;

    void start()
    {
        MaxHealth = CurrentHealth;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }

    void TakeDemage()
    {
        MaxHealth -= Demage;
    }
}