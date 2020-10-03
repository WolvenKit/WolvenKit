<?xml version="1.0"?><doc>
<members>
<member name="T:IrrlichtLime.Video.Light" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="11">
<summary>
Describes a dynamic point light.
Irrlicht supports point lights, spot lights, and directional lights.
</summary>
</member>
<member name="M:IrrlichtLime.Video.Light.#ctor" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="19">
<summary>
Default constructor.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.AmbientColor" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="24">
<summary>
Ambient color emitted by the light.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Attenuation" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="29">
<summary>
Attenuation factors (constant, linear, quadratic).
Changes the light strength fading over distance.
Can also be altered by setting the Radius, Attenuation will change to (0,1.0f/Radius,0).
Can be overridden after radius was set.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.CastShadows" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="37">
<summary>
Does the light cast shadows?
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.DiffuseColor" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="42">
<summary>
Diffuse color emitted by the light.
This is the primary color you want to set.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Direction" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="48">
<summary>
Direction of the light.
If Type is <see cref="F:IrrlichtLime.Video.LightType.Point"/>, it is ignored.
Changed via light scene node's rotation.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Falloff" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="55">
<summary>
The light strength's decrease between Outer and Inner cone.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.InnerCone" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="60">
<summary>
The angle of the spot's inner cone.
Ignored for other lights.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.OuterCone" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="66">
<summary>
The angle of the spot's outer cone.
Ignored for other lights.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Position" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="72">
<summary>
Position of the light.
If Type is <see cref="F:IrrlichtLime.Video.LightType.Directional"/>, it is ignored.
Changed via light scene node's position.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Radius" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="79">
<summary>
Radius of the light.
Everything within this radius will be lighted.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.SpecularColor" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="85">
<summary>
Specular color emitted by the light.
For details how to use specular highlights, see <c>Material.Shininess</c>.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Type" decl="false" source="d:\tools\wk\wolvenkit.irrlichtlime\light.h" line="91">
<summary>
Type of the light.
</summary>
</member>
<member name="M:IrrlichtLime.Scene.Mesh.SetDirty(IrrlichtLime.Scene.HardwareBufferType)" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\mesh.h" line="31">
<summary>Flag the meshbuffer as changed, reloads hardware buffers.
This method has to be called every time the vertices or indices have changed. Otherwise, changes won't be updated on the GPU in the next render cycle.</summary>
<param name="buffer">Type of buffer to flag as changed. Default: <see cref="F:IrrlichtLime.Scene.HardwareBufferType.VertexAndIndex"/>.</param>
</member>
<member name="M:IrrlichtLime.Scene.Mesh.SetDirty" decl="true" source="d:\tools\wk\wolvenkit.irrlichtlime\mesh.h" line="36">
<summary>Flag the meshbuffer as changed, reloads hardware buffers.
This method has to be called every time the vertices or indices have changed. Otherwise, changes won't be updated on the GPU in the next render cycle.</summary>
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