using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whopperCollision : MonoBehaviour
{
    public MeshRenderer foodMesh;
    private FoodScore FoodScore;
    void OnTriggerEnter (Collider other)
    {
        FoodScore.score ++;
        foodMesh.enabled = false;
    }
}
