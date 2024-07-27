### [Home](../ReadMe.md)

# ImgUi Design

## ImGuiWindowFlags

Flags can be set when creating windows for a multitude of customizations.

- **ImGuiWindowFlags_None**: No flags.
- **ImGuiWindowFlags_NoTitleBar**: Disable the title bar.
- **ImGuiWindowFlags_NoResize**: Disable user resizing with the lower-right grip.
- **ImGuiWindowFlags_NoMove**: Disable user moving the window.
- **ImGuiWindowFlags_NoScrollbar**: Disable scrollbars (window can still scroll with mouse or programmatically).
- **ImGuiWindowFlags_NoScrollWithMouse**: Disable user vertically scrolling with the mouse wheel.
- **ImGuiWindowFlags_NoCollapse**: Disable user collapsing window by double-clicking on it.
- **ImGuiWindowFlags_AlwaysAutoResize**: Resize every window to its content every frame.
- **ImGuiWindowFlags_NoBackground**: Disable drawing background color (window background will be transparent).
- **ImGuiWindowFlags_NoSavedSettings**: Never load/save settings in `ini` file.
- **ImGuiWindowFlags_NoMouseInputs**: Disable catching mouse, hovering test with pass through.
- **ImGuiWindowFlags_MenuBar**: Has a menu-bar.
- **ImGuiWindowFlags_HorizontalScrollbar**: Allow horizontal scrollbar to appear (off by default).
- **ImGuiWindowFlags_NoFocusOnAppearing**: Disable taking focus when transitioning from hidden to visible state.
- **ImGuiWindowFlags_NoBringToFrontOnFocus**: Disable bringing window to front when taking focus (e.g. clicking on it or programmatically giving it focus).
- **ImGuiWindowFlags_AlwaysVerticalScrollbar**: Always show vertical scrollbar (even if ContentSize.y < Size.y).
- **ImGuiWindowFlags_AlwaysHorizontalScrollbar**: Always show horizontal scrollbar (even if ContentSize.x < Size.x).
- **ImGuiWindowFlags_AlwaysUseWindowPadding**: Ensure child windows without border uses style.WindowPadding (ignored by default for non-bordered child windows, because more convenient).
- **ImGuiWindowFlags_NoNavInputs**: No gamepad/keyboard navigation within the window.
- **ImGuiWindowFlags_NoNavFocus**: No focusing toward this window with gamepad/keyboard navigation (e.g. skipped by CTRL+TAB).
- **ImGuiWindowFlags_UnsavedDocument**: Display a dot next to the title.
- **ImGuiWindowFlags_NoDocking**: Disable docking of this window.

### ImGuiWindowFlags for internal use

- **ImGuiWindowFlags_NoNav**: (WIP) = `NoNavInputs | NoNavFocus`.
- **ImGuiWindowFlags_NoDecoration**: = `NoTitleBar | NoResize | NoScrollbar | NoCollapse`.
- **ImGuiWindowFlags_NoInputs**: = `NoMouseInputs | NoNavInputs | NoNavFocus`.

### Usage

    ImGui.Begin("Example Window", ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoMove);