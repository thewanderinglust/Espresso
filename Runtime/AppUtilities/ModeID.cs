using UnityEngine;

/// <summary>
/// Used to create IDs for Modes. Allows users to create whichever IDs they want for whichever modes their game needs.
/// </summary>
[CreateAssetMenu(fileName = "ModeID", menuName = "Espresso/ModeID")]
public class ModeID : ScriptableObject
{
    /// <summary>
    /// String name of this ID for easier identifications in debugging.
    /// </summary>
    [SerializeField] private string m_name;

    /// <summary>
    /// Getter property for the string name of this ID.
    /// </summary>
    public string Name {get { return m_name; } }
}
