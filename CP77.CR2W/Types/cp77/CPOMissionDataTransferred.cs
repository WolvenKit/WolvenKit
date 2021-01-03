using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataTransferred : redEvent
	{
		[Ordinal(0)]  [RED("choiceTokenTimeout")] public CUInt32 ChoiceTokenTimeout { get; set; }
		[Ordinal(1)]  [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(2)]  [RED("dataDamagesPresetName")] public CName DataDamagesPresetName { get; set; }
		[Ordinal(3)]  [RED("dataDownloaded")] public CBool DataDownloaded { get; set; }
		[Ordinal(4)]  [RED("isChoiceToken")] public CBool IsChoiceToken { get; set; }
		[Ordinal(5)]  [RED("ownerDecidesOnTransfer")] public CBool OwnerDecidesOnTransfer { get; set; }

		public CPOMissionDataTransferred(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
