using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BraindanceInputChangeEvent : redEvent
	{
		[Ordinal(0)]  [RED("bdSystem")] public CHandle<BraindanceSystem> BdSystem { get; set; }

		public BraindanceInputChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
