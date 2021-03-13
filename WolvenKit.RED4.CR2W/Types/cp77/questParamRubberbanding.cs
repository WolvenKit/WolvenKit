using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questParamRubberbanding : ISerializable
	{
		[Ordinal(0)] [RED("targetRef")] public CHandle<questUniversalRef> TargetRef { get; set; }
		[Ordinal(1)] [RED("minDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(2)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(3)] [RED("stopAndWait")] public CBool StopAndWait { get; set; }
		[Ordinal(4)] [RED("teleportToCatchUp")] public CBool TeleportToCatchUp { get; set; }
		[Ordinal(5)] [RED("stayInFront")] public CBool StayInFront { get; set; }

		public questParamRubberbanding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
