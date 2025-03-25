using UnityEngine;

public class FlipperController : MonoBehaviour
{
    public enum FlipperType { Left, Right, Up }
    public FlipperType flipperType;
    
    public float flipperForce = 1000f;
    public float restPosition = 0f;
    public float activePosition = 45f;

    private HingeJoint hinge;
    private JointSpring spring;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        spring = hinge.spring;
        spring.spring = flipperForce;
        hinge.useSpring = true;
    }

    void Update()
    {
        bool pressed = false;

        switch (flipperType)
        {
            case FlipperType.Left:
                pressed = Input.GetKey(KeyCode.LeftArrow);
                break;
            case FlipperType.Right:
                pressed = Input.GetKey(KeyCode.RightArrow);
                break;
            case FlipperType.Up:
                pressed = Input.GetKey(KeyCode.UpArrow);
                break;
        }

        spring.targetPosition = pressed ? activePosition : restPosition;
        hinge.spring = spring;
    }
}
