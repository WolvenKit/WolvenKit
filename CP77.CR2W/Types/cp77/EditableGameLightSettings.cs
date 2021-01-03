using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class EditableGameLightSettings : CVariable
	{
		[Ordinal(0)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("innerAngle")] public CFloat InnerAngle { get; set; }
		[Ordinal(3)]  [RED("intensity")] public CFloat Intensity { get; set; }
		[Ordinal(4)]  [RED("modifyColor")] public CBool ModifyColor { get; set; }
		[Ordinal(5)]  [RED("modifyInnerAngle")] public CBool ModifyInnerAngle { get; set; }
		[Ordinal(6)]  [RED("modifyIntensity")] public CBool ModifyIntensity { get; set; }
		[Ordinal(7)]  [RED("modifyOuterAngle")] public CBool ModifyOuterAngle { get; set; }
		[Ordinal(8)]  [RED("modifyRadius")] public CBool ModifyRadius { get; set; }
		[Ordinal(9)]  [RED("modifyStrength")] public CBool ModifyStrength { get; set; }
		[Ordinal(10)]  [RED("outerAngle")] public CFloat OuterAngle { get; set; }
		[Ordinal(11)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(12)]  [RED("strength")] public CFloat Strength { get; set; }

		public EditableGameLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
