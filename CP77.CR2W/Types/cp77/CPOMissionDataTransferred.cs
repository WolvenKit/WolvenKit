using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataTransferred : redEvent
	{
		[Ordinal(0)] [RED("dataDownloaded")] public CBool DataDownloaded { get; set; }
		[Ordinal(1)] [RED("dataDamagesPresetName")] public CName DataDamagesPresetName { get; set; }
		[Ordinal(2)] [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(3)] [RED("ownerDecidesOnTransfer")] public CBool OwnerDecidesOnTransfer { get; set; }
		[Ordinal(4)] [RED("isChoiceToken")] public CBool IsChoiceToken { get; set; }
		[Ordinal(5)] [RED("choiceTokenTimeout")] public CUInt32 ChoiceTokenTimeout { get; set; }

		public CPOMissionDataTransferred(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
