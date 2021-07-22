using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteInstance : MonoBehaviour
{
    [SerializeField] NoteGenerator noteGenerator = default;
    public void NoteEvent()
    {
        noteGenerator.SpawnNote();
    }
}
