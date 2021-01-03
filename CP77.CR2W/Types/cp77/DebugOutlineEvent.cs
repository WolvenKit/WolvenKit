using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DebugOutlineEvent : redEvent
	{
		[Ordinal(0)]  [RED("opacity")] public CFloat Opacity { get; set; }
		[Ordinal(1)]  [RED("requester")] public entEntityID Requester { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<EOutlineType> Type { get; set; }

		public DebugOutlineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
