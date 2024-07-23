# ImGui.Net

## Setup

* Create a C# Console project in Visual Studio.
* Add the following Nugget packages: Veldrid.Imgui, Veldrid.StartupUtilities (Imgui requires a Backend UI API, we're using Veldrid here)
* Right click the project > Properties > Output Type > Windows Application


## Sample program

    using ImGuiNET;
    using Veldrid;
    using Veldrid.StartupUtilities;

    class Program
    {
        static void Main(string[] args)
        {
            VeldridStartup.CreateWindowAndGraphicsDevice(
                new WindowCreateInfo(100, 100, 1280, 720, Veldrid.WindowState.Normal, "ImGui Example"),
                out var window,
                out var gd);
            ImGuiRenderer imguiRenderer = new ImGuiRenderer(
                gd, gd.MainSwapchain.Framebuffer.OutputDescription,
                (int)gd.MainSwapchain.Framebuffer.Width, (int)gd.MainSwapchain.Framebuffer.Height);
            var cl = gd.ResourceFactory.CreateCommandList();

            while (window.Exists)
            {
                var input = window.PumpEvents();
                if (!window.Exists) { break; }
                imguiRenderer.Update(1f / 60f, input); // Compute actual value for deltaSeconds.

                // Draw stuff
                ImguiTest.Render();

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

### Sample component

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