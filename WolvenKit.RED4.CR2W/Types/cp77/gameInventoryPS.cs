using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventoryPS : gameComponentPS
	{
		[Ordinal(0)] [RED("isRegisteredShared")] public CBool IsRegisteredShared { get; set; }
		[Ordinal(1)] [RED("accessible")] public CBool Accessible { get; set; }

		public gameInventoryPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
