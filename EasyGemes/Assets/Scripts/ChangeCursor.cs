using UnityEngine;

public class ChangeCursor : MonoBehaviour {
	[SerializeField] Texture2D cursorImage;

	void Start() {
		Cursor.SetCursor(cursorImage, new Vector2(cursorImage.width / 2, cursorImage.height / 2), CursorMode.ForceSoftware);
	}
}
