using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridY;

    // Cost from Starting Node to This Node
    public int gCost;
    // Cost from Target Node to This Node
    public int hCost;
    public Node parent;

    public Node(bool _walkable, Vector3 _worldPosition, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPosition = _worldPosition;
        gridX = _gridX;
        gridY = _gridY;
    }

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }
}
