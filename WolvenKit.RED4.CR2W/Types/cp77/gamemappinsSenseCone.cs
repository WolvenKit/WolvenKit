using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsSenseCone : CVariable
	{
		[Ordinal(0)] [RED("length")] public CFloat Length { get; set; }
		[Ordinal(1)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(2)] [RED("angleDegrees")] public CFloat AngleDegrees { get; set; }
		[Ordinal(3)] [RED("position1")] public Vector4 Position1 { get; set; }
		[Ordinal(4)] [RED("position2")] public Vector4 Position2 { get; set; }

		public gamemappinsSenseCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
