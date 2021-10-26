using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class showNotificationOnTrigger : MonoBehaviour {

    [Tooltip("Text to be shown")]
    public string displayText;

    [Tooltip("Timeout after activation before next activation (in seconds)")]
    public float showingTimeOut;

    private Collider m_Collider;

    private NotificationHUDManager m_NotificationHUDManager;

    private float? timeSinceLastShown = null;

    public bool showAtAll = true;


    // Start is called before the first frame update
    void Start() {
        m_Collider = GetComponent<Collider>();
        DebugUtility.HandleErrorIfNullGetComponent<Collider, teleportDonut>(m_Collider, this, gameObject);

        m_Collider.isTrigger = true;

        m_NotificationHUDManager = FindObjectOfType<NotificationHUDManager>();
        DebugUtility.HandleErrorIfNullFindObject<NotificationHUDManager, moveObjectOnDie>(m_NotificationHUDManager, this);
    }

    // Update is called once per frame
    void Update() {
        if (timeSinceLastShown != null)
            timeSinceLastShown += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) {
        if (timeSinceLastShown < showingTimeOut || timeSinceLastShown == -1) return;
        PlayerCharacterController enteringPlayer = other.GetComponent<PlayerCharacterController>();

        // Check if the entering entity is actually a player
        if (enteringPlayer != null) {
            m_NotificationHUDManager.CreateNotification(displayText);
            timeSinceLastShown = 0;
        }
    }
}
