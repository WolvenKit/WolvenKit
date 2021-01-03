using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DisplayGlass : InteractiveDevice
	{
		[Ordinal(0)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(1)]  [RED("isDestroyed")] public CBool IsDestroyed { get; set; }

		public DisplayGlass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
