using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecordData : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CString Name { get; set; }
		[Ordinal(1)]  [RED("score")] public CUInt32 Score { get; set; }

		public gameuiPanzerScoreRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
