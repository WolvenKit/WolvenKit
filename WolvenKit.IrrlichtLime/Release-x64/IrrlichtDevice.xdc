<?xml version="1.0"?><doc>
<members>
<member name="T:IrrlichtLime.JoystickInfo" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="10">
<summary>
Information on a joystick, returned from <c>device.ActivateJoysticks()</c>.
</summary>
</member>
<member name="T:IrrlichtLime.JoystickInfo.PovHatPresence" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="17">
<summary>
An indication of whether the joystick has a POV hat.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.PovHatPresence.Present" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="22">
<summary>
A hat is definitely present.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.PovHatPresence.Absent" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="27">
<summary>
A hat is definitely not present.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.PovHatPresence.Unknown" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="32">
<summary>
The presence or absence of a hat cannot be determined.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.AxisCount" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="38">
<summary>
The number of axes that the joystick has, i.e. X, Y, Z, R, U, V.
Note: with a Linux device, the POV hat (if any) will use two axes. These will be included in this count.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.ButtonCount" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="44">
<summary>
The number of buttons that the joystick has.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.Joystick" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="49">
<summary>
The ID of the joystick.
This is an internal Irrlicht index; it does not map directly to any particular hardware joystick.
It corresponds to the <c>JoystickEvent.Joystick</c> value.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.Name" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="56">
<summary>
The name that the joystick uses to identify itself.
</summary>
</member>
<member name="F:IrrlichtLime.JoystickInfo.PovHat" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\joystickinfo.h" line="61">
<summary>
An indication of whether the joystick has a POV hat.
A Windows device will identify the presence or absence of the POV hat.
A Linux device cannot, and will always return <see cref="F:IrrlichtLime.JoystickInfo.PovHatPresence.Unknown"/>.
</summary>
</member>
<member name="T:IrrlichtLime.Logger" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="12">
<summary>
Logging messages, warnings and errors.
</summary>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String,System.String,IrrlichtLime.LogLevel)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="19">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
<param name="hint">Additional info. This string is added after a " :" to the string.</param>
<param name="level">Log level of the text. Default is <see cref="F:IrrlichtLime.LogLevel.Information"/>.</param>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String,IrrlichtLime.LogLevel)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="27">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
<param name="level">Log level of the text. Default is <see cref="F:IrrlichtLime.LogLevel.Information"/>.</param>
</member>
<member name="M:IrrlichtLime.Logger.Log(System.String)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="34">
<summary>
Prints out a text into the log.
</summary>
<param name="text">Text to print out.</param>
</member>
<member name="P:IrrlichtLime.Logger.LogLevel" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\logger.h" line="40">
<summary>
Current log level.
With this value, texts which are sent to the logger are filtered out.
For example setting this value to <see cref="F:IrrlichtLime.LogLevel.Warning"/>, only warnings and errors are printed out.
Setting it to <see cref="F:IrrlichtLime.LogLevel.Information"/>, which is the default setting, warnings, errors and informational texts are printed out.
</summary>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single,System.Byte,IrrlichtLime.Video.ExposedVideoData,IrrlichtLime.Core.Recti)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="45">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
<param name="videoData">Handle of another window, if you want the bitmap to be displayed on another window.
If this is an empty element, everything will be displayed in the default window.
Note: This feature is not fully implemented for all devices. Default is null.</param>
<param name="sourceRect">Rectangle defining the source rectangle of the area to be presented.
Note: not implemented in all devices. Default is null (present everything).</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single,System.Byte,IrrlichtLime.Video.ExposedVideoData)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="60">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
<param name="videoData">Handle of another window, if you want the bitmap to be displayed on another window.
If this is an empty element, everything will be displayed in the default window.
Note: This feature is not fully implemented for all devices. Default is null.</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single,System.Byte)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="73">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="83">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="92">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is null (black).</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene(IrrlichtLime.Video.ClearBufferFlag)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="100">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.BeginScene" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="107">
<summary>
Applications must call this method before performing any rendering. This method can clear the back- and the z-buffer.
</summary>
<returns>False if failed.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.SetRenderTarget(IrrlichtLime.Video.Texture,IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single,System.Byte)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="278">
<summary>
Sets a new render target.
This will only work if the driver supports the <see cref="F:IrrlichtLime.Video.VideoDriverFeature.RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
</summary>
<param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is black.</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<param name="clearStencil">The clear value for the stencil buffer. Default is 0.</param>
<returns>True if successful and false if not.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.SetRenderTarget(IrrlichtLime.Video.Texture,IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color,System.Single)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="293">
<summary>
Sets a new render target.
This will only work if the driver supports the <see cref="F:IrrlichtLime.Video.VideoDriverFeature.RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
</summary>
<param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is black.</param>
<param name="clearDepth">The clear value for the depth buffer. Default is 1.f.</param>
<returns>True if successful and false if not.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.SetRenderTarget(IrrlichtLime.Video.Texture,IrrlichtLime.Video.ClearBufferFlag,IrrlichtLime.Video.Color)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="307">
<summary>
Sets a new render target.
This will only work if the driver supports the <see cref="F:IrrlichtLime.Video.VideoDriverFeature.RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
</summary>
<param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<param name="clearColor">The clear color for the color buffer. Default is black.</param>
<returns>True if successful and false if not.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.SetRenderTarget(IrrlichtLime.Video.Texture,IrrlichtLime.Video.ClearBufferFlag)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="320">
<summary>
Sets a new render target.
This will only work if the driver supports the <see cref="F:IrrlichtLime.Video.VideoDriverFeature.RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
</summary>
<param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
<param name="clearFlag">A combination of the <see cref="T:IrrlichtLime.Video.ClearBufferFlag"/> bit-flags. Default is <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Color"/> | <see cref="F:IrrlichtLime.Video.ClearBufferFlag.Depth"/>.</param>
<returns>True if successful and false if not.</returns>
</member>
<member name="M:IrrlichtLime.Video.VideoDriver.SetRenderTarget(IrrlichtLime.Video.Texture)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\videodriver.h" line="332">
<summary>
Sets a new render target.
This will only work if the driver supports the <see cref="F:IrrlichtLime.Video.VideoDriverFeature.RenderToTarget"/>, which can be queried with <c>QueryFeature()</c>.
Please note that you cannot render 3D or 2D geometry with a render target as texture on it when you are rendering the scene into this render target
at the same time. It is usually only possible to render into a texture between the <c>BeginScene()</c> and <c>EndScene()</c> calls.
</summary>
<param name="texture">New render target. Must be a texture created with <c>AddRenderTargetTexture()</c>.
If set to <c>null</c>, it sets the previous render target which was set before the last method call.</param>
<returns>True if successful and false if not.</returns>
</member>
</members>
</doc>