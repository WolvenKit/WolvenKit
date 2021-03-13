using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(7)] [RED("result")] public CEnum<GenericMessageNotificationResult> Result { get; set; }

		public GenericMessageNotificationCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
