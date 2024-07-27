using ImGuiNET;

namespace BookImGui
{
    public class TopNavbar
    {
        public static void Render()
        {
            // Begin Menu Bar
            if (ImGui.BeginMainMenuBar())
            {
                // Begin "File" Menu
                if (ImGui.BeginMenu("File"))
                {
                    // Add Menu Items here
                    if (ImGui.MenuItem("Open"))
                    {
                        // Handle Open action
                    }
                    if (ImGui.MenuItem("Save"))
                    {
                        // Handle Save action
                    }

                    // End "File" Menu
                    ImGui.EndMenu();
                }

                Program.NavBarHeight = ImGui.GetWindowHeight();

                // End Main Menu Bar
                ImGui.EndMainMenuBar();
            }
        }
    }
}
