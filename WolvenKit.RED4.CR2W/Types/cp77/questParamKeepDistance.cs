using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamKeepDistance : ISerializable
	{
		[Ordinal(0)] [RED("companionTargetRef")] public CHandle<questUniversalRef> CompanionTargetRef { get; set; }
		[Ordinal(1)] [RED("distance")] public CFloat Distance { get; set; }

		public questParamKeepDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
