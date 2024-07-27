### [Home](../ReadMe.md)

# Layouts

## Vertical stack

By default, ImGui places items vertically one after the other, so no special function is needed. You can use NewLine() to add vertical spacing between items if necessary.

    ImGui.Button("Button 1");
    ImGui.Button("Button 2");
    ImGui.Button("Button 3");

## Horizontal stack

Use SameLine() to place items next to each other horizontally.

    ImGui.Button("Button 1");
    ImGui.SameLine();
    ImGui.Button("Button 2");
    ImGui.SameLine();
    ImGui.Button("Button 3");

## Columns

Use Columns() to create multiple columns within a window. You can switch between columns using NextColumn().

    ImGui.Columns(3, "mycolumns", true); // 3 columns
    ImGui.Text("Column 1, Row 1");
    ImGui.NextColumn();
    ImGui.Text("Column 2, Row 1");
    ImGui.NextColumn();
    ImGui.Text("Column 3, Row 1");

    ImGui.NextColumn();
    ImGui.Text("Column 1, Row 2");
    ImGui.NextColumn();
    ImGui.Text("Column 2, Row 2");
    ImGui.NextColumn();
    ImGui.Text("Column 3, Row 2");

    ImGui.Columns(1); // Reset to single column mode

## Grouping

Use BeginGroup() and EndGroup() to group multiple items together, which can be useful for alignment and layout.

    ImGui.BeginGroup();
    ImGui.Text("Group 1");
    ImGui.Button("Button 1");
    ImGui.EndGroup();

    ImGui.SameLine();

    ImGui.BeginGroup();
    ImGui.Text("Group 2");
    ImGui.Button("Button 2");
    ImGui.EndGroup();

## Child Windows (Scrollable)

Use BeginChild() and EndChild() to create child windows, which can act as scrollable regions.

    ImGui.BeginChild("ChildWindow", new Vector2(200, 100), true);
    ImGui.Text("This is inside the child window.");
    ImGui.Button("Button 1");
    ImGui.Button("Button 2");
    ImGui.EndChild();

## Reusable layouts

To create more reusable and modular layouts, you can define custom functions that encapsulate specific layouts.

    void HorizontalLayout(Action content)
    {
        ImGui.BeginGroup();
        content();
        ImGui.EndGroup();
        ImGui.SameLine();
    }

    void VerticalLayout(Action content)
    {
        ImGui.BeginGroup();
        content();
        ImGui.EndGroup();
    }

    // Usage
    HorizontalLayout(() => {
        ImGui.Button("Button 1");
        ImGui.Button("Button 2");
        ImGui.Button("Button 3");
    });

    VerticalLayout(() => {
        ImGui.Button("Button A");
        ImGui.Button("Button B");
        ImGui.Button("Button C");
    });