using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animActionAnimDatabase_DatabaseRow : CVariable
	{
		[Ordinal(0)] [RED("animFeatureName")] public CName AnimFeatureName { get; set; }
		[Ordinal(1)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(2)] [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(3)] [RED("animationData")] public animActionAnimDatabase_AnimationData AnimationData { get; set; }

		public animActionAnimDatabase_DatabaseRow(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
