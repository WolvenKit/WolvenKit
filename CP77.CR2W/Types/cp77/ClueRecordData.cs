using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ClueRecordData : CVariable
	{
		[Ordinal(0)]  [RED("clueRecord")] public TweakDBID ClueRecord { get; set; }
		[Ordinal(1)]  [RED("facts")] public CArray<SFactOperationData> Facts { get; set; }
		[Ordinal(2)]  [RED("percentage")] public CFloat Percentage { get; set; }
		[Ordinal(3)]  [RED("wasInspected")] public CBool WasInspected { get; set; }

		public ClueRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
