using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionLook : gameIMuppetInputAction
	{
		[Ordinal(0)]  [RED("rotation")] public Vector2 Rotation { get; set; }

		public gameMuppetInputActionLook(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
