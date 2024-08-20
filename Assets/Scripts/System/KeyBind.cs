using System.Collections.Generic;
using UnityEngine;

public static class KeyBind
{
    public enum Action
    {
        Move_Forward,
        Move_Backward,
        Move_Left,
        Move_Right,
        Weapon_One,
        Weapon_Two,
        Weapon_Three,
        Weapon_Four,
        Sprint,
        Jump,
        Roll,
        Dash,
        Interact,
        BasicSkill,
    }

    public static Dictionary<Action, KeyCode> keys = new Dictionary<Action, KeyCode>();

    public static KeyCode move_forward => keys[Action.Move_Forward];
    public static KeyCode move_backward => keys[Action.Move_Backward];
    public static KeyCode move_left => keys[Action.Move_Left];
    public static KeyCode move_right => keys[Action.Move_Right];

    public static KeyCode weapon_one => keys[Action.Weapon_One];
    public static KeyCode weapon_two => keys[Action.Weapon_Two];
    public static KeyCode weapon_three => keys[Action.Weapon_Three];
    public static KeyCode weapon_four => keys[Action.Weapon_Four];

    public static KeyCode sprint => keys[Action.Sprint];
    public static KeyCode jump => keys[Action.Jump];
    public static KeyCode roll => keys[Action.Roll];
    public static KeyCode dash => keys[Action.Dash];

    public static KeyCode interact => keys[Action.Interact];
    public static KeyCode basicSkill => keys[Action.BasicSkill];

    static KeyBind()
    {
        keys[Action.Move_Forward] = KeyCode.W;
        keys[Action.Move_Backward] = KeyCode.S;
        keys[Action.Move_Left] = KeyCode.A;
        keys[Action.Move_Right] = KeyCode.D;

        keys[Action.Weapon_One] = KeyCode.Alpha1;
        keys[Action.Weapon_Two] = KeyCode.Alpha2;
        keys[Action.Weapon_Three] = KeyCode.Alpha3;
        keys[Action.Weapon_Four] = KeyCode.Alpha4;

        keys[Action.Sprint] = KeyCode.LeftShift;
        keys[Action.Jump] = KeyCode.V;
        keys[Action.Roll] = KeyCode.Space;
        keys[Action.Dash] = KeyCode.LeftControl;

        keys[Action.Interact] = KeyCode.F;
        keys[Action.BasicSkill] = KeyCode.Mouse0;
    }
}