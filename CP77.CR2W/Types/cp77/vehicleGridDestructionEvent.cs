using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleGridDestructionEvent : redEvent
	{
		[Ordinal(0)]  [RED("desiredChange", 16)] public CArrayFixedSize<CFloat> DesiredChange { get; set; }
		[Ordinal(1)]  [RED("rawChange", 16)] public CArrayFixedSize<CFloat> RawChange { get; set; }
		[Ordinal(2)]  [RED("state", 16)] public CArrayFixedSize<CFloat> State { get; set; }

		public vehicleGridDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
