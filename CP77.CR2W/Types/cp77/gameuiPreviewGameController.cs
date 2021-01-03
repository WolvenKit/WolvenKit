using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("isRotatable")] public CBool IsRotatable { get; set; }
		[Ordinal(1)]  [RED("yawDefault")] public CFloat YawDefault { get; set; }
		[Ordinal(2)]  [RED("yawSpeed")] public CFloat YawSpeed { get; set; }

		public gameuiPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
