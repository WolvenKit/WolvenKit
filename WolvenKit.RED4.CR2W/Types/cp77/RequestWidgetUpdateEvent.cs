using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestWidgetUpdateEvent : redEvent
	{
		[Ordinal(0)] [RED("requester")] public gamePersistentID Requester { get; set; }
		[Ordinal(1)] [RED("screenDefinition")] public ScreenDefinitionPackage ScreenDefinition { get; set; }

		public RequestWidgetUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
