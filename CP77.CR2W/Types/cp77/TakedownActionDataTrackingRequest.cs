using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TakedownActionDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("eventType")] public CEnum<ETakedownActionType> EventType { get; set; }

		public TakedownActionDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
