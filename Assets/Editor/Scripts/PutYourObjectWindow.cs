using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace MOB.Editor
{
    /// <summary>
    /// PutYourObjectEditor
    /// </summary>
    public sealed class PutYourObjectWindow : EditorWindow
    {
        private const int GUI_BUTTON_WIDTH = 35;
        
        [MenuItem("Window/PutYourObjectWindow")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(PutYourObjectWindow));
        }
        
        private ReorderableList _reorderableList;
        private List<string> _stringList = new List<string>(){"0", "1", "2"}; //表示する要素

        private void OnEnable (){
            //ReorderableListを作成
            _reorderableList = new ReorderableList(
                elements            : _stringList,    //要素
                elementType         : typeof(string), //要素の種類
                draggable           : true,           //ドラッグして要素を入れ替えられるか
                displayHeader       : true,           //ヘッダーを表示するか
                displayAddButton    : true,           //要素追加用の+ボタンを表示するか
                displayRemoveButton : true            //要素削除用の-ボタンを表示するか
            );
            
            //要素の描画の設定
            _reorderableList.drawElementCallback += DrawElement;
        }

        private void DrawElement(Rect rect, int index, bool isactive, bool isfocused)
        {
            EditorGUI.TextField(rect, _stringList[index]);
            
            if (GUI.Button(new Rect(x: rect.x + rect.width - GUI_BUTTON_WIDTH, y: rect.y, GUI_BUTTON_WIDTH, rect.height), "選択"))
            {
                Debug.Log("選択！");
            }
        }

        private void OnGUI(){
            //ReorderableListを表示
            _reorderableList.DoLayoutList();
        }
    }
}
