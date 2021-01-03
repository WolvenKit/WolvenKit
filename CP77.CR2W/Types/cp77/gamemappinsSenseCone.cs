using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsSenseCone : CVariable
	{
		[Ordinal(0)]  [RED("angleDegrees")] public CFloat AngleDegrees { get; set; }
		[Ordinal(1)]  [RED("length")] public CFloat Length { get; set; }
		[Ordinal(2)]  [RED("position1")] public Vector4 Position1 { get; set; }
		[Ordinal(3)]  [RED("position2")] public Vector4 Position2 { get; set; }
		[Ordinal(4)]  [RED("width")] public CFloat Width { get; set; }

		public gamemappinsSenseCone(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
