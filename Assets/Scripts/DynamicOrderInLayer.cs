using UnityEngine;

public class DynamicOrderInLayer : MonoBehaviour
{
    [SerializeField]
    private TopDownLayer[] top_down_layer_list;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !collision.isTrigger)
        {
            foreach (TopDownLayer top_d_layer in top_down_layer_list)
                top_d_layer.OnEnterLayerSprite();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !collision.isTrigger)
        {
            foreach (TopDownLayer top_d_layer in top_down_layer_list)
                top_d_layer.OnExitLayerSprite();
        }
    }

    [System.Serializable]
    private class TopDownLayer
    {
        [SerializeField]
        private SpriteRenderer object_sprite;
        [SerializeField]
        private int order_in_layer_enter;
        [SerializeField]
        private int order_in_layer_exit;
    
        public void OnEnterLayerSprite()
        {
            object_sprite.sortingOrder = order_in_layer_enter;
        }

        public void OnExitLayerSprite()
        {
            object_sprite.sortingOrder = order_in_layer_exit;
        }
    }
}
