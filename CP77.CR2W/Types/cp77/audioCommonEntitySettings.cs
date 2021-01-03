using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioCommonEntitySettings : CVariable
	{
		[Ordinal(0)]  [RED("onAttachEvent")] public CName OnAttachEvent { get; set; }
		[Ordinal(1)]  [RED("onDetachEvent")] public CName OnDetachEvent { get; set; }
		[Ordinal(2)]  [RED("stopAllSoundsOnDetach")] public CBool StopAllSoundsOnDetach { get; set; }

		public audioCommonEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
