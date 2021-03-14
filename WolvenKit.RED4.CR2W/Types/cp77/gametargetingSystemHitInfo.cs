using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemHitInfo : CVariable
	{
		[Ordinal(0)] [RED("queryMask")] public CUInt64 QueryMask { get; set; }
		[Ordinal(1)] [RED("entityId")] public entEntityID EntityId { get; set; }
		[Ordinal(2)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(3)] [RED("component")] public wCHandle<entIComponent> Component { get; set; }
		[Ordinal(4)] [RED("aimStartPosition")] public Vector4 AimStartPosition { get; set; }
		[Ordinal(5)] [RED("closestHitPosition")] public Vector4 ClosestHitPosition { get; set; }
		[Ordinal(6)] [RED("isTransparent")] public CBool IsTransparent { get; set; }

		public gametargetingSystemHitInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
