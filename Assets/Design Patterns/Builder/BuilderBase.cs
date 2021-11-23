using UnityEngine;

public abstract class BuilderBase : MonoBehaviour
{
    protected IBuild building;
    public IBuild GetBuilding() => building;
}
