using UnityEngine;

[RequireComponent(typeof(Pickup))]
public class ActivateObjectiveOnPickup : MonoBehaviour
{
    [Tooltip("The prefab for the objective to be activated when picking up weapon")]
    public GameObject objective;

    Pickup m_Pickup;

    void Start()
    {
        m_Pickup = GetComponent<Pickup>();
        DebugUtility.HandleErrorIfNullGetComponent<Pickup, WeaponPickup>(m_Pickup, this, gameObject);

        // Subscribe to pickup action
        m_Pickup.onPick += OnPicked;
    }

    void OnPicked(PlayerCharacterController byPlayer)
    {
        if (objective.GetComponent<Objective>())
        {
            objective.SetActive(true);
        }
    }
}
