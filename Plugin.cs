using UnityEngine;

namespace DraggableGizmos
{
    public class Plugin : IllusionPlugin.IPlugin
    {
        private GameObject draggableObject; // Reference to the GameObject with the DraggableGizmo script

        public string Name { get { return "DraggableGizmo"; } }

        public string Version { get { return "1.0"; } }

        public void OnApplicationQuit()
        {
            // Clean up any resources if needed
        }

        public void OnApplicationStart()
        {
            // Check if the DraggableGizmo script is already available
            if (draggableObject == null)
            {
                // The script is not available, so create a dummy GameObject and attach it
                draggableObject = new GameObject("DraggableObject");
                draggableObject.AddComponent<DraggableGizmo>();
            }
        }

        public void OnFixedUpdate()
        {
            // Implement your logic for FixedUpdate if needed
        }

        public void OnLateUpdate()
        {
            // Implement your logic for LateUpdate if needed
        }

        public void OnUpdate()
        {
            // Implement your logic for Update if needed
        }

        public void OnLevelWasInitialized(int level)
        {
            // This method is called when a new level is initialized in the game
        }

        public void OnLevelWasLoaded(int level)
        {
            // This method is called when a level is loaded in the game
        }
    }
}
