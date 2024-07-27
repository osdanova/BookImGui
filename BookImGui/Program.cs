using BookImGui;
using ImGuiNET;
using System.Diagnostics;
using System.Numerics;
using Veldrid;
using Veldrid.Sdl2;
using Veldrid.StartupUtilities;

class Program
{
    public static float NavBarHeight = 0;

    static void Main(string[] args)
    {

        // MAIN WINDOW - Uses Veldrid
        VeldridStartup.CreateWindowAndGraphicsDevice(
            new WindowCreateInfo(100, 100, 1280, 720, Veldrid.WindowState.Normal, "ImGui Example"),
            out Sdl2Window window,
            out GraphicsDevice gd);

        // IMGUI RENDERER - Required to use ImGui
        ImGuiRenderer imguiRenderer = new ImGuiRenderer(
            gd, gd.MainSwapchain.Framebuffer.OutputDescription,
            (int)gd.MainSwapchain.Framebuffer.Width, (int)gd.MainSwapchain.Framebuffer.Height);

        // Command List - Graphics device renderer
        CommandList cl = gd.ResourceFactory.CreateCommandList();

        while (window.Exists)
        {
            InputSnapshot input = window.PumpEvents(); // Catches user input
            if (!window.Exists) { break; }
            imguiRenderer.Update(1f / 60f, input); // Compute actual value for deltaSeconds.

            // Begin Main Menu Bar
            TopNavbar.Render();

            float nvh = NavBarHeight;

            // Begin MainContainer
            ImGui.SetNextWindowSize(new System.Numerics.Vector2(window.Width, window.Height - NavBarHeight));
            ImGui.SetNextWindowPos(new System.Numerics.Vector2(0, NavBarHeight));

            // Save the current style
            ImGuiStylePtr style = ImGui.GetStyle();
            Vector4 originalBorderColor = style.Colors[(int)ImGuiCol.Border];

            // Set transparent border color
            style.Colors[(int)ImGuiCol.Border] = new Vector4(0, 0, 0, 0); // RGBA with alpha = 0 for transparency

            ImGui.PushStyleVar(ImGuiStyleVar.WindowRounding, 0.0f);
            ImGui.Begin("MainContainer", ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoTitleBar);
            {
                style.Colors[(int)ImGuiCol.Border] = originalBorderColor;
                ImGui.PopStyleVar();
                ImguiTest.Render();
            }
            ImGui.End();


            // Render ImGui
            cl.Begin();
            cl.SetFramebuffer(gd.MainSwapchain.Framebuffer);
            cl.ClearColorTarget(0, RgbaFloat.Black);
            imguiRenderer.Render(gd, cl);
            cl.End();
            gd.SubmitCommands(cl);
            gd.SwapBuffers(gd.MainSwapchain);
        }
    }
}