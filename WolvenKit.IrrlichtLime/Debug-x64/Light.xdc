<?xml version="1.0"?><doc>
<members>
<member name="T:IrrlichtLime.Video.Light" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="11">
<summary>
Describes a dynamic point light.
Irrlicht supports point lights, spot lights, and directional lights.
</summary>
</member>
<member name="M:IrrlichtLime.Video.Light.#ctor" decl="true" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="19">
<summary>
Default constructor.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.AmbientColor" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="24">
<summary>
Ambient color emitted by the light.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Attenuation" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="29">
<summary>
Attenuation factors (constant, linear, quadratic).
Changes the light strength fading over distance.
Can also be altered by setting the Radius, Attenuation will change to (0,1.0f/Radius,0).
Can be overridden after radius was set.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.CastShadows" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="37">
<summary>
Does the light cast shadows?
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.DiffuseColor" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="42">
<summary>
Diffuse color emitted by the light.
This is the primary color you want to set.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Direction" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="48">
<summary>
Direction of the light.
If Type is <see cref="F:IrrlichtLime.Video.LightType.Point"/>, it is ignored.
Changed via light scene node's rotation.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Falloff" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="55">
<summary>
The light strength's decrease between Outer and Inner cone.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.InnerCone" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="60">
<summary>
The angle of the spot's inner cone.
Ignored for other lights.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.OuterCone" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="66">
<summary>
The angle of the spot's outer cone.
Ignored for other lights.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Position" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="72">
<summary>
Position of the light.
If Type is <see cref="F:IrrlichtLime.Video.LightType.Directional"/>, it is ignored.
Changed via light scene node's position.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Radius" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="79">
<summary>
Radius of the light.
Everything within this radius will be lighted.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.SpecularColor" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="85">
<summary>
Specular color emitted by the light.
For details how to use specular highlights, see <c>Material.Shininess</c>.
</summary>
</member>
<member name="P:IrrlichtLime.Video.Light.Type" decl="false" source="D:\Tools\WK\WolvenKit.IrrlichtLime\Light.h" line="91">
<summary>
Type of the light.
</summary>
</member>
</members>
</doc>