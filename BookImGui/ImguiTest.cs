using ImGuiNET;
using System.Diagnostics;

namespace BookImGui
{
    public class ImguiTest
    {
        static bool isChecked = false;
        public static void Render()
        {
            ImGui.BeginChild("TESTING", new System.Numerics.Vector2(300, 0), true);
            ImGui.Text("Hello World");
            ImGui.Text("Hello World 2");

            ImGui.Checkbox("Check", ref isChecked);
            if (ImGui.Button("Button"))
            {
                Debug.WriteLine("Is checked: " + isChecked);
            }
            ImGui.EndChild();
        }
    }
}
