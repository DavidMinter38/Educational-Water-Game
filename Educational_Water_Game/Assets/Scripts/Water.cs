using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public Sprite filteredSprite;
    public GameObject filteredDirt;

    private SpriteRenderer waterSpriteRenderer;
    private FilterControl filterObject;

    bool filtered = false;

    // Start is called before the first frame update
    void Start()
    {
        waterSpriteRenderer = GetComponent<SpriteRenderer>();
        filterObject = FindObjectOfType<FilterControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -7)
        {
            if (!filtered)
            {
                FindObjectOfType<ScoreManager>().ReduceLives();
            }
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            waterSpriteRenderer.sprite = filteredSprite;
            GameObject spawnedDirt = Instantiate(filteredDirt, new Vector3(this.transform.position.x, filterObject.transform.position.y+0.4f, 0), Quaternion.identity);
            spawnedDirt.transform.parent = filterObject.transform;
            FindObjectOfType<ScoreManager>().AddToScore();
            filtered = true;
        }
        
    }
}
