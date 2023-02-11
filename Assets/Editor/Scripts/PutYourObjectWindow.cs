using UnityEditor;

namespace MOB.Editor
{
    /// <summary>
    /// PutYourObjectEditor
    /// </summary>
    public sealed class PutYourObjectWindow : EditorWindow
    {
        [MenuItem("Window/PutYourObjectWindow")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(PutYourObjectWindow));
        }
    }
}
