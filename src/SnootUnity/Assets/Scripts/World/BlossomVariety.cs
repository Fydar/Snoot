using UnityEngine;

public class BlossomVariety : MonoBehaviour
{
    public Sprite[] RandomSprites;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = RandomSprites[GetComponentInParent<Plant>().TreeType];
    }
}
