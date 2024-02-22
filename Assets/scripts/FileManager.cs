/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[System.Serializable]
public class Achievement
{
    public string Name;
    public string Description;
}

[System.Serializable]
public class Employee
{
    public string Name;
    public string Family;
    public string Age;
}

[System.Serializable]
public class CompanyData
{
    public string CompanyName;
    public string CompanyAddress;
    public string CompanyDescription;
    public List<Achievement> Achievements;
    public List<Employee> Employees;
}

public class FileManager : MonoBehaviour
{
    string filePath;

    public RawImage rawImage;
    public Text companyText;

    public void OpenFileBrowserAndLoad()
    {
        filePath = EditorUtility.OpenFilePanel("Select File", "", "");
        if (!string.IsNullOrEmpty(filePath))
        {
            LoadFile();
        }
    }

    public void ResetPanels()
    {
        // Clear raw image
        if (rawImage != null)
        {
            rawImage.texture = null;
        }

        // Clear text panel
        if (companyText != null)
        {
            companyText.text = "";
        }
    }

    void LoadFile()
    {
        if (filePath.ToLower().EndsWith(".png") || filePath.ToLower().EndsWith(".jpg") || filePath.ToLower().EndsWith(".jpeg"))
        {
            // Load image
            LoadImage();
        }
        else if (filePath.ToLower().EndsWith(".json"))
        {
            // Load JSON data
            LoadJsonData();
        }
        else
        {
            Debug.LogWarning("Unsupported file type");
        }
    }

    void LoadImage()
    {
        WWW www = new WWW("file:///" + filePath);
        rawImage.texture = www.texture;
    }

    void LoadJsonData()
    {
        string jsonData = System.IO.File.ReadAllText(filePath);
        CompanyData companyData = JsonUtility.FromJson<CompanyData>(jsonData);

        // Display the data in the text panel
        if (companyText != null)
        {
            string achievementsText = "";
            foreach (var achievement in companyData.Achievements)
            {
                achievementsText += $"{achievement.Name}: {achievement.Description}\n";
            }

            string employeesText = "";
            foreach (var employee in companyData.Employees)
            {
                employeesText += $"Name: {employee.Name}, Family: {employee.Family}, Age: {employee.Age}\n";
            }

            companyText.text = $"Company: {companyData.CompanyName}\nAddress: {companyData.CompanyAddress}\nDescription: {companyData.CompanyDescription}\n\nAchievements:\n{achievementsText}\nEmployees:\n{employeesText}";
        }
    }
}
*/