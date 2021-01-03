using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeakspotOnDestroyEvent : redEvent
	{
		[Ordinal(0)]  [RED("weakspotRecordData")] public WeakspotRecordData WeakspotRecordData { get; set; }

		public WeakspotOnDestroyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
