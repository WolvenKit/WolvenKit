using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkedFocusClueData : CVariable
	{
		[Ordinal(0)] [RED("clueGroupID")] public CName ClueGroupID { get; set; }
		[Ordinal(1)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(2)] [RED("clueIndex")] public CInt32 ClueIndex { get; set; }
		[Ordinal(3)] [RED("clueRecord")] public TweakDBID ClueRecord { get; set; }
		[Ordinal(4)] [RED("extendedClueRecords")] public CArray<ClueRecordData> ExtendedClueRecords { get; set; }
		[Ordinal(5)] [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(6)] [RED("wasInspected")] public CBool WasInspected { get; set; }
		[Ordinal(7)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(8)] [RED("psData")] public PSOwnerData PsData { get; set; }

		public LinkedFocusClueData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
