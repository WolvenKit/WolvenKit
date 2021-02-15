using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CurrencyUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("diff")] public CInt32 Diff { get; set; }
		[Ordinal(6)] [RED("total")] public CUInt32 Total { get; set; }

		public CurrencyUpdateNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
