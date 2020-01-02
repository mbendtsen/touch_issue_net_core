# Description 
This is a repos project to demonstrate an issue with touch and .NET Core.
This requires a touch enabled device.

The issue is that if a splash screen has been shown in another thread, then touch is not working in the main window. This works in .NET Framework, but not .NET Core 3.1.

# How to use
1. Clone repository
1. Build and run
1. Touch/tap the white area.

Expected: Two events should be shown in the black box, `PreviewMouseDown` and `PreviewTouchDown`. Touch scrolling does not work.

Actual: One event is shown, `PreviewMouseDown`.

# Making it work in .NET Framework.
1. Open project file
1. Change netcoreapp3.1 to net462
1. Build and run
1. Touch/tap the white area.

Actual: Two event is shown, `PreviewMouseDown` and `PreviewTouchDown`. Touch scrolling works.
