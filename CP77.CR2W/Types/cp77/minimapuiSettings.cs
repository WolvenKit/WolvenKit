using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class minimapuiSettings : CVariable
	{
		[Ordinal(0)]  [RED("hideTime")] public CFloat HideTime { get; set; }
		[Ordinal(1)]  [RED("showTime")] public CFloat ShowTime { get; set; }

		public minimapuiSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
