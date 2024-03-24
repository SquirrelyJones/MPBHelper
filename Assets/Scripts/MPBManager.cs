using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBManager : MonoBehaviour
{
    public static MPBManager instance;

    private static HashSet<MPBHelper> mpbHelpers = new HashSet<MPBHelper>();

    public static void AddUpdate(MPBHelper mpbHelper) {
        mpbHelpers.Add(mpbHelper);
    }

    public static void RemoveUpdate(MPBHelper mpbHelper) {
        mpbHelpers.Remove(mpbHelper);
    }

    private void Awake() {
        instance = this;
        mpbHelpers.Clear();
    }

    private void LateUpdate() {
        foreach (MPBHelper mpbHelper in mpbHelpers) {
            //if (mpbHelper == null) continue;
            mpbHelper.UpdatePropertyBlock();
        }

        mpbHelpers.Clear();

    }
}
