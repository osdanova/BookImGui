using ImGuiNET;

namespace BookImGui
{
    public class RightMenu
    {
        public static void Render()
        {
            ImGui.BeginChild("RightMenu", new System.Numerics.Vector2(200, 0), true); // RightMenu width is 200px, height is dynamic
            ImGui.Text("This is the right menu.");
            ImGui.EndChild();
        }
    }
}
