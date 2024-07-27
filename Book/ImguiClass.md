### [Home](../ReadMe.md)

# ImgUi Class

## Window Functions
- **Begin(string name, ref bool open, ImGuiWindowFlags flags)**: Starts a new window. If the `open` parameter is `false`, the window will not appear. The `flags` parameter can be used to specify various window options.
- **End()**: Ends the current window. Every `Begin` call should be matched with an `End` call.

## Menu Functions
- **BeginMenuBar()**: Starts a menu bar at the top of the current window. Should be called within a window.
- **EndMenuBar()**: Ends a menu bar. Should be called after `BeginMenuBar`.
- **BeginMainMenuBar()**: Creates and appends to a full-screen menu bar.
- **EndMainMenuBar()**: Ends a main menu bar. Should be called after `BeginMainMenuBar`.
- **BeginMenu(string label, bool enabled = true)**: Starts a new menu. Should be called between `BeginMenuBar` and `EndMenuBar`.
- **EndMenu()**: Ends the current menu. Should be called after `BeginMenu`.
- **MenuItem(string label, string shortcut = null, bool selected = false, bool enabled = true)**: Creates a menu item within a menu. Can optionally display a shortcut and be selected or disabled.

## Input Functions
- **InputText(string label, ref string buf, uint buf_size, ImGuiInputTextFlags flags = 0)**: Creates an input text field. The `buf` parameter is a reference to the input buffer.
- **InputTextMultiline(string label, ref string buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags = 0)**: Creates a multiline input text field.
- **InputFloat(string label, ref float v, float step = 0, float step_fast = 0, string format = "%.3f", ImGuiInputTextFlags flags = 0)**: Creates an input field for a float value.
- **InputFloat2(string label, ref Vector2 v, string format = "%.3f", ImGuiInputTextFlags flags = 0)**: Creates an input field for two float values.
- **InputFloat3(string label, ref Vector3 v, string format = "%.3f", ImGuiInputTextFlags flags = 0)**: Creates an input field for three float values.
- **InputFloat4(string label, ref Vector4 v, string format = "%.3f", ImGuiInputTextFlags flags = 0)**: Creates an input field for four float values.
- **InputInt(string label, ref int v, int step = 1, int step_fast = 100, ImGuiInputTextFlags flags = 0)**: Creates an input field for an integer value.
- **InputInt2(string label, ref int v, ImGuiInputTextFlags flags = 0)**: Creates an input field for two integer values.
- **InputInt3(string label, ref int v, ImGuiInputTextFlags flags = 0)**: Creates an input field for three integer values.
- **InputInt4(string label, ref int v, ImGuiInputTextFlags flags = 0)**: Creates an input field for four integer values.
- **InputDouble(string label, ref double v, double step = 0, double step_fast = 0, string format = "%.6f", ImGuiInputTextFlags flags = 0)**: Creates an input field for a double value.

## Button Functions
- **Button(string label, Vector2 size = default(Vector2))**: Creates a button with the given label and size.
- **SmallButton(string label)**: Creates a smaller version of a button.
- **InvisibleButton(string str_id, Vector2 size)**: Creates an invisible button (only responds to clicks, not visible).
- **ArrowButton(string str_id, ImGuiDir dir)**: Creates an arrow button with a specified direction.
- **Checkbox(string label, ref bool v)**: Creates a checkbox with the given label. The `v` parameter is a reference to the boolean value.
- **CheckboxFlags(string label, ref uint flags, uint flags_value)**: Creates a checkbox for setting bits in flags.

## Radio Button Functions
- **RadioButton(string label, bool active)**: Creates a radio button with the given label.
- **RadioButton(string label, ref int v, int v_button)**: Creates a radio button for setting integer values.

## Slider Functions
- **SliderFloat(string label, ref float v, float v_min, float v_max, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a slider for float values.
- **SliderFloat2(string label, ref Vector2 v, float v_min, float v_max, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a slider for two float values.
- **SliderFloat3(string label, ref Vector3 v, float v_min, float v_max, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a slider for three float values.
- **SliderFloat4(string label, ref Vector4 v, float v_min, float v_max, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a slider for four float values.
- **SliderAngle(string label, ref float v_rad, float v_degrees_min = -360.0f, float v_degrees_max = +360.0f, string format = "%.0f deg", ImGuiSliderFlags flags = 0)**: Creates a slider for angles in radians.
- **SliderInt(string label, ref int v, int v_min, int v_max, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a slider for integer values.
- **SliderInt2(string label, ref int v, int v_min, int v_max, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a slider for two integer values.
- **SliderInt3(string label, ref int v, int v_min, int v_max, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a slider for three integer values.
- **SliderInt4(string label, ref int v, int v_min, int v_max, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a slider for four integer values.

## Drag Functions
- **DragFloat(string label, ref float v, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a drag control for float values.
- **DragFloat2(string label, ref Vector2 v, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a drag control for two float values.
- **DragFloat3(string label, ref Vector3 v, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a drag control for three float values.
- **DragFloat4(string label, ref Vector4 v, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string format = "%.3f", ImGuiSliderFlags flags = 0)**: Creates a drag control for four float values.
- **DragFloatRange2(string label, ref float v_current_min, ref float v_current_max, float v_speed = 1.0f, float v_min = 0.0f, float v_max = 0.0f, string format = "%.3f", string format_max = null, ImGuiSliderFlags flags = 0)**: Creates a drag control for a float range.
- **DragInt(string label, ref int v, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a drag control for integer values.
- **DragInt2(string label, ref int v, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a drag control for two integer values.
- **DragInt3(string label, ref int v, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a drag control for three integer values.
- **DragInt4(string label, ref int v, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string format = "%d", ImGuiSliderFlags flags = 0)**: Creates a drag control for four integer values.
- **DragIntRange2(string label, ref int v_current_min, ref int v_current_max, float v_speed = 1.0f, int v_min = 0, int v_max = 0, string format = "%d", string format_max = null, ImGuiSliderFlags flags = 0)**: Creates a drag control for an integer range.

## Color Functions
- **ColorEdit3(string label, ref Vector3 col, ImGuiColorEditFlags flags = 0)**: Creates a color editor for an RGB color.
- **ColorEdit4(string label, ref Vector4 col, ImGuiColorEditFlags flags = 0)**: Creates a color editor for an RGBA color.
- **ColorPicker3(string label, ref Vector3 col, ImGuiColorEditFlags flags = 0)**: Creates a color picker for an RGB color.
- **ColorPicker4(string label, ref Vector4 col, ImGuiColorEditFlags flags = 0, ref float alpha_bar = 1.0f)**: Creates a color picker for an RGBA color.
- **ColorButton(string desc_id, Vector4 col, ImGuiColorEditFlags flags = 0, Vector2 size = default(Vector2))**: Creates a color button.
- **SetColorEditOptions(ImGuiColorEditFlags flags)**: Sets color edit options.

## Tooltip Functions
- **BeginTooltip()**: Starts a tooltip. Should be called when a tooltip is desired.
- **EndTooltip()**: Ends a tooltip. Should be called after `BeginTooltip`.
- **SetTooltip(string text)**: Sets the text of the tooltip directly.

## Tree Functions
- **TreeNode(string label)**: Creates a tree node with the given label.
- **TreeNode(string str_id, string fmt, params object[] args)**: Creates a tree node with a formatted label.
- **TreeNodeEx(string label, ImGuiTreeNodeFlags flags = 0)**: Creates a tree node with additional flags.
- **TreeNodeEx(string str_id, ImGuiTreeNodeFlags flags, string fmt, params object[] args)**: Creates a tree node with a formatted label and additional flags.
- **TreePush(string str_id = null)**: Indents subsequent tree nodes.
- **TreePop()**: Unindents the tree level by one.
- **GetTreeNodeToLabelSpacing()**: Returns the spacing between the tree node and its label.
- **CollapsingHeader(string label, ImGuiTreeNodeFlags flags = 0)**: Creates a collapsing header.
- **CollapsingHeader(string label, ref bool open, ImGuiTreeNodeFlags flags = 0)**: Creates a collapsing header with a boolean state.

## Selectable Functions
- **Selectable(string label, bool selected = false, ImGuiSelectableFlags flags = 0, Vector2 size = default(Vector2))**: Creates a selectable item.
- **Selectable(string label, ref bool p_selected, ImGuiSelectableFlags flags = 0, Vector2 size = default(Vector2))**: Creates a selectable item with a reference to a boolean state.

## ListBox Functions
- **ListBox(string label, ref int current_item, string[] items, int height_in_items = -1)**: Creates a list box with a list of string items.
- **ListBox(string label, ref int current_item, ref string items_getter, int items_count, int height_in_items = -1)**: Creates a list box with a custom item getter function.

## Combo Functions
- **BeginCombo(string label, string preview_value, ImGuiComboFlags flags = 0)**: Begins a combo box.
- **EndCombo()**: Ends a combo box.
- **Combo(string label, ref int current_item, string[] items, int popup_max_height_in_items = -1)**: Creates a combo box with a list of string items.

## Plot Functions
- **PlotLines(string label, ref float values, int values_count, int values_offset = 0, string overlay_text = null, float scale_min = float.MaxValue, float scale_max = float.MaxValue, Vector2 graph_size = default(Vector2), int stride = sizeof(float))**: Plots a series of lines.
- **PlotHistogram(string label, ref float values, int values_count, int values_offset = 0, string overlay_text = null, float scale_min = float.MaxValue, float scale_max = float.MaxValue, Vector2 graph_size = default(Vector2), int stride = sizeof(float))**: Plots a histogram.

## ProgressBar Function
- **ProgressBar(float fraction, Vector2 size_arg = default(Vector2), string overlay = null)**: Creates a progress bar.

## Miscellaneous Functions
- **SameLine(float offset_from_start_x = 0.0f, float spacing = -1.0f)**: Draws widgets on the same line.
- **NewLine()**: Inserts a new line.
- **Separator()**: Inserts a horizontal line separator.
- **Spacing()**: Inserts vertical spacing.
- **Dummy(Vector2 size)**: Inserts an invisible widget of a given size.
- **Indent(float indent_w = 0.0f)**: Indents following widgets.
- **Unindent(float indent_w = 0.0f)**: Unindents following widgets.
- **BeginGroup()**: Begins a group of widgets.
- **EndGroup()**: Ends a group of widgets.
- **GetCursorPos()**: Gets the cursor position relative to the current window.
- **SetCursorPos(Vector2 local_pos)**: Sets the cursor position relative to the current window.
- **GetCursorScreenPos()**: Gets the cursor position in screen coordinates.
- **SetCursorScreenPos(Vector2 pos)**: Sets the cursor position in screen coordinates.
- **AlignTextToFramePadding()**: Vertically aligns text baseline to the center of the frame padding.
- **Text(string text)**: Displays text.
- **TextColored(Vector4 col, string text)**: Displays colored text.
- **TextDisabled(string text)**: Displays disabled text.
- **TextWrapped(string text)**: Displays wrapped text.
- **LabelText(string label, string text)**: Displays a text label with a value.
- **Bullet()**: Draws a bullet point.
- **BulletText(string text)**: Draws a bullet point with text.

## Layout Functions
- **Columns(int count = 1, string id = null, bool border = true)**: Creates a column layout. Use `NextColumn` to switch between columns.
- **NextColumn()**: Moves to the next column in a column layout.
- **GetColumnIndex()**: Returns the current column index.
- **GetColumnWidth(int column_index = -1)**: Returns the width of a column.
- **SetColumnWidth(int column_index, float width)**: Sets the width of a column.
- **GetColumnOffset(int column_index = -1)**: Returns the offset of a column.
- **SetColumnOffset(int column_index, float offset_x)**: Sets the offset of a column.
- **GetColumnsCount()**: Returns the number of columns.

## Tab Bar Functions
- **BeginTabBar(string str_id, ImGuiTabBarFlags flags = 0)**: Begins a tab bar.
- **EndTabBar()**: Ends a tab bar.
- **BeginTabItem(string label, ref bool open, ImGuiTabItemFlags flags = 0)**: Begins a tab item.
- **EndTabItem()**: Ends a tab item.
- **SetTabItemClosed(string tab_or_docked_window_label)**: Closes a tab item.

## Child Window Functions
- **BeginChild(string str_id, Vector2 size = default(Vector2), bool border = false, ImGuiWindowFlags flags = 0)**: Begins a child window.
- **EndChild()**: Ends a child window.
- **BeginChild(uint id, Vector2 size = default(Vector2), bool border = false, ImGuiWindowFlags flags = 0)**: Begins a child window with an ID.

## Clipping Functions
- **PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)**: Pushes a clipping rectangle.
- **PopClipRect()**: Pops the last pushed clipping rectangle.

## Focus Functions
- **SetItemDefaultFocus()**: Sets the default focus on the last item.
- **SetKeyboardFocusHere(int offset = 0)**: Sets keyboard focus on the next widget.

## Scroll Functions
- **GetScrollX()**: Gets the horizontal scroll amount.
- **GetScrollY()**: Gets the vertical scroll amount.
- **GetScrollMaxX()**: Gets the maximum horizontal scroll amount.
- **GetScrollMaxY()**: Gets the maximum vertical scroll amount.
- **SetScrollX(float scroll_x)**: Sets the horizontal scroll amount.
- **SetScrollY(float scroll_y)**: Sets the vertical scroll amount.
- **SetScrollHereX(float center_x_ratio = 0.5f)**: Scrolls to the current item along the X-axis.
- **SetScrollHereY(float center_y_ratio = 0.5f)**: Scrolls to the current item along the Y-axis.
- **SetScrollFromPosX(float local_x, float center_x_ratio = 0.5f)**: Scrolls to a given position along the X-axis.
- **SetScrollFromPosY(float local_y, float center_y_ratio = 0.5f)**: Scrolls to a given position along the Y-axis.

## Drag and Drop Functions
- **BeginDragDropSource(ImGuiDragDropFlags flags = 0)**: Begins a drag-and-drop source.
- **SetDragDropPayload(string type, IntPtr data, int size, ImGuiCond cond = ImGuiCond.None)**: Sets the payload for a drag-and-drop operation.
- **EndDragDropSource()**: Ends a drag-and-drop source.
- **BeginDragDropTarget()**: Begins a drag-and-drop target.
- **AcceptDragDropPayload(string type, ImGuiDragDropFlags flags = 0)**: Accepts a drag-and-drop payload.
- **EndDragDropTarget()**: Ends a drag-and-drop target.

## Miscellaneous Functions
- **PushStyleColor(ImGuiCol idx, uint col)**: Pushes a color style.
- **PopStyleColor(int count = 1)**: Pops a color style.
- **PushStyleVar(ImGuiStyleVar idx, float val)**: Pushes a style variable.
- **PopStyleVar(int count = 1)**: Pops a style variable.
- **PushItemWidth(float item_width)**: Pushes item width.
- **PopItemWidth()**: Pops item width.
- **SetNextItemWidth(float item_width)**: Sets the width of the next item.
- **CalcTextSize(string text, string text_end = null, bool hide_text_after_double_hash = false, float wrap_width = -1.0f)**: Calculates the size of the given text.
- **GetTextLineHeight()**: Returns the height of a text line.
- **GetTextLineHeightWithSpacing()**: Returns the height of a text line with spacing.
- **GetFrameHeight()**: Returns the height of a frame.
- **GetFrameHeightWithSpacing()**: Returns the height of a frame with spacing.
- **PushID(int int_id)**: Pushes an integer ID onto the ID stack.
- **PushID(string str_id)**: Pushes a string ID onto the ID stack.
- **PushID(IntPtr ptr_id)**: Pushes a pointer ID onto the ID stack.
- **PopID()**: Pops an ID from the ID stack.
- **GetID(string str_id)**: Returns a unique ID for the given string.
- **GetID(IntPtr ptr_id)**: Returns a unique ID for the given pointer.
