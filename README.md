# Description 
This is a repros project to demonstrate an issue with touch and .NET Core.
This requires a touch enabled device.

The issue is that if a splash screen has been shown in another thread, then touch is not working in the main window. This works in .NET Framework, but not .NET Core 3.1.

# How to use
## .NET Core
1. Open project file
1. Set target framework to netcore3.1
1. Build and run
1. Touch/tap the white area.

- Expected: Two events should be shown in the black box, `PreviewMouseDown` and `PreviewTouchDown`. Touch scrolling does work.
- Actual: One event is shown, `PreviewMouseDown`. Touch scrolling does not work

## .NET Framework.
1. Open project file
1. Set target framework to net462
1. Build and run
1. Touch/tap the white area.

- Expected: Two events should be shown in the black box, `PreviewMouseDown` and `PreviewTouchDown`. Touch scrolling does work.
- Actual: Two event is shown, `PreviewMouseDown` and `PreviewTouchDown`. Touch scrolling works.
