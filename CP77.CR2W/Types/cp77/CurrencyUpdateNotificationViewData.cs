using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CurrencyUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("diff")] public CInt32 Diff { get; set; }
		[Ordinal(1)]  [RED("total")] public CUInt32 Total { get; set; }

		public CurrencyUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
