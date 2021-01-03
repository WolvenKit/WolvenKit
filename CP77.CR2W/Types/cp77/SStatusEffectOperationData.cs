using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SStatusEffectOperationData : CVariable
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("effect")] public gameStatusEffectTDBPicker Effect { get; set; }
		[Ordinal(2)]  [RED("offset")] public Vector4 Offset { get; set; }
		[Ordinal(3)]  [RED("range")] public CFloat Range { get; set; }

		public SStatusEffectOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
