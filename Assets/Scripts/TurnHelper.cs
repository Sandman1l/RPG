using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class TurnHelper : MonoBehaviour 
{
    protected List<Unit> Units;
    protected void AgilitySort()
    {
        Units = new List<Unit>(Units.OrderByDescending(u => u.ag));
    }
}