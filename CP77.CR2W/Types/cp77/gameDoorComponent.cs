using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDoorComponent : entIComponent
	{
		[Ordinal(0)]  [RED("autoOpeningSpeed")] public CFloat AutoOpeningSpeed { get; set; }
		[Ordinal(1)]  [RED("automatic")] public CBool Automatic { get; set; }
		[Ordinal(2)]  [RED("interactible")] public CBool Interactible { get; set; }
		[Ordinal(3)]  [RED("physical")] public CBool Physical { get; set; }

		public gameDoorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
