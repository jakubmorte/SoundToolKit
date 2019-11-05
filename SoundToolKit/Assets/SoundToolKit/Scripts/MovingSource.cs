// \author: Michal Majewski
// \date: 13.03.2019

using UnityEngine;

/// <summary>
/// A behaviour that moves the object from Point1 to Point2 and back at a given speed;
/// </summary>
public class MovingSource : MonoBehaviour
{
    #region public properties

    [SerializeField]
    public Vector3 Point1 = new Vector3(0, 0, 0);

    [SerializeField]
    public Vector3 Point2 = new Vector3(1, 1, 1);

    [SerializeField]
    public float speed = 0.1f;

    #endregion

    #region private methods

    private void Awake()
    {
        gameObject.transform.position = Point1;
    }

    private void Update()
    {
        if (!m_reversedMovment)
        {
            MoveTowards(Point2);
        }
        else
        {
            MoveTowards(Point1);
        }
    }

    private void MoveTowards(Vector3 point)
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, point, speed);

        if (Vector3.Distance(gameObject.transform.position, point) < 0.001f)
        {
            m_reversedMovment = !m_reversedMovment;
        }
    }

    #endregion

    #region private members

    private bool m_reversedMovment = false;

    #endregion
}
