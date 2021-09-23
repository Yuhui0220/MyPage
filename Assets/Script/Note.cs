using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text contentText;

    string noteName;
    string Contents;

    public void NoteBtn(string _noteName)
    {
        noteName = _noteName;
        string filePath = "Assets/Note/" + noteName + ".txt";
        Contents = ReadTxt(filePath);

        nameText.text = noteName;
        contentText.text = Contents;    }

    string ReadTxt(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        string value = "";

        if (fileInfo.Exists)
        {
            StreamReader reader = new StreamReader(filePath);
            value = reader.ReadToEnd();
            reader.Close();
        }

        else
            value = "파일이 없습니다.";

        return value;
    }
}
