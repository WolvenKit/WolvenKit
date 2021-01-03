using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questParamKeepDistance : ISerializable
	{
		[Ordinal(0)]  [RED("companionTargetRef")] public CHandle<questUniversalRef> CompanionTargetRef { get; set; }
		[Ordinal(1)]  [RED("distance")] public CFloat Distance { get; set; }

		public questParamKeepDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
