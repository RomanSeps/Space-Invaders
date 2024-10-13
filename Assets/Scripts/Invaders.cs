using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invaders[] prefabs;

    public int rows = 5;

    public int columns = 11;

    private void Awake(){
        for(int row = 0; row< this.rows; row++){
            Vector3 rowPosition = new Vector3(0.0f, row * 2.0f, 0.0f);
            for(int col = 0; col < this.columns; col++){
                Invaders invader = Instantiate(this.prefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col = 2.0f;
                invader.transform.position = position;
            }
        }
    }
}
