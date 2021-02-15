using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataState : IScriptable
	{
		[Ordinal(0)] [RED("CPOMissionDataDamagesPreset")] public CName CPOMissionDataDamagesPreset { get; set; }
		[Ordinal(1)] [RED("compatibleDeviceName")] public CName CompatibleDeviceName { get; set; }
		[Ordinal(2)] [RED("ownerDecidesOnTransfer")] public CBool OwnerDecidesOnTransfer { get; set; }
		[Ordinal(3)] [RED("isChoiceToken")] public CBool IsChoiceToken { get; set; }
		[Ordinal(4)] [RED("choiceTokenTimeout")] public CUInt32 ChoiceTokenTimeout { get; set; }
		[Ordinal(5)] [RED("delayedGiveChoiceTokenEventId")] public gameDelayID DelayedGiveChoiceTokenEventId { get; set; }
		[Ordinal(6)] [RED("dataDamageTextLayerId")] public CUInt32 DataDamageTextLayerId { get; set; }

		public CPOMissionDataState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
