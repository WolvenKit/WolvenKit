using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleFlippedOverEvent : redEvent
	{
		[Ordinal(0)]  [RED("isFlippedOver")] public CBool IsFlippedOver { get; set; }

		public vehicleFlippedOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
