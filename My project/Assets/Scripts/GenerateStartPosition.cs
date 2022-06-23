using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStartPosition : MonoBehaviour
{
    private List<int> xsPos = new List<int>();
    private List<int> ysPos = new List<int>();
    private List<int> zsPos = new List<int>();
    private List<int> xsRot = new List<int>();
    private List<int> ysRot = new List<int>();
    private List<int> zsRot = new List<int>();
    public GameObject car;
    void Start()
    {
        car.transform.rotation = new Quaternion(0,0,0,0);
        GetPosition();
    }

    private void GetPosition()
    {
        xsPos.Add(-474);
        ysPos.Add(70);
        zsPos.Add(8);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-420);
        ysPos.Add(70);
        zsPos.Add(12);
        xsRot.Add(0);
        ysRot.Add(-90);
        zsRot.Add(0);

        xsPos.Add(-404);
        ysPos.Add(70);
        zsPos.Add(42);
        xsRot.Add(0);
        ysRot.Add(180);
        zsRot.Add(0);

        xsPos.Add(-420);
        ysPos.Add(70);
        zsPos.Add(54);
        xsRot.Add(0);
        ysRot.Add(-90);
        zsRot.Add(0);

        xsPos.Add(-460);
        ysPos.Add(70);
        zsPos.Add(50);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-380);
        ysPos.Add(70);
        zsPos.Add(8);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-400);
        ysPos.Add(70);
        zsPos.Add(24);
        xsRot.Add(0);
        ysRot.Add(0);
        zsRot.Add(0);

        xsPos.Add(-356);
        ysPos.Add(70);
        zsPos.Add(54);
        xsRot.Add(0);
        ysRot.Add(-90);
        zsRot.Add(0);

        xsPos.Add(-370);
        ysPos.Add(70);
        zsPos.Add(50);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-376);
        ysPos.Add(70);
        zsPos.Add(8);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-350);
        ysPos.Add(70);
        zsPos.Add(12);
        xsRot.Add(0);
        ysRot.Add(-90);
        zsRot.Add(0);

        xsPos.Add(-326);
        ysPos.Add(70);
        zsPos.Add(-31);
        xsRot.Add(0);
        ysRot.Add(0);
        zsRot.Add(0);

        xsPos.Add(-296);
        ysPos.Add(70);
        zsPos.Add(7);
        xsRot.Add(0);
        ysRot.Add(90);
        zsRot.Add(0);

        xsPos.Add(-266);
        ysPos.Add(70);
        zsPos.Add(12);
        xsRot.Add(0);
        ysRot.Add(-90);
        zsRot.Add(0);

        int index = Random.Range(0,xsPos.Count);
        car.transform.position = new Vector3(xsPos[index],ysPos[index],zsPos[index]);
        car.transform.Rotate(xsRot[index],ysRot[index],zsRot[index],Space.Self);
    }
}
