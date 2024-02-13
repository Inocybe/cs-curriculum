using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathButtonScript : MonoBehaviour
{ 
    private HudManager manager;
    public GameObject buttonPrefab;

    private void Start()
    {
        manager = FindObjectOfType<HudManager>();
        
        for (int i = 0, len = manager.spawnPoints.Count; i < len; i++)
        {
            if (manager.spawnPoints.ElementAt(i).Value)
            {
                GameObject button = Instantiate(buttonPrefab, transform);
                button.transform.position += new Vector3(0f, -30 * i, 0f);
                button.GetComponentInChildren<TextMeshProUGUI>().text = "SpawnPoint: " + (i + 1);
                var index = i;
                button.GetComponent<Button>().onClick.AddListener(() => { SelectSpawnpoint(index); });
            } 
        }
    }
    
    public void SelectSpawnpoint(int spawnIndex)
    {
        manager.selectedSpawnIndex = spawnIndex;
        SceneManager.LoadScene(2);
    }
}
