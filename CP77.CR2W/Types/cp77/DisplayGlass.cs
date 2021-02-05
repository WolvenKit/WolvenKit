using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisplayGlass : InteractiveDevice
	{
		[Ordinal(84)]  [RED("collider")] public CHandle<entIPlacedComponent> Collider { get; set; }
		[Ordinal(85)]  [RED("isDestroyed")] public CBool IsDestroyed { get; set; }

		public DisplayGlass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
