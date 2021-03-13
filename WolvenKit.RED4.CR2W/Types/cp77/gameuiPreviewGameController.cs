using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(3)] [RED("yawSpeed")] public CFloat YawSpeed { get; set; }
		[Ordinal(4)] [RED("yawDefault")] public CFloat YawDefault { get; set; }
		[Ordinal(5)] [RED("isRotatable")] public CBool IsRotatable { get; set; }

		public gameuiPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
