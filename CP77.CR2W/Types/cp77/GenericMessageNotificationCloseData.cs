using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationCloseData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("identifier")] public CInt32 Identifier { get; set; }
		[Ordinal(1)]  [RED("result")] public CEnum<GenericMessageNotificationResult> Result { get; set; }

		public GenericMessageNotificationCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
