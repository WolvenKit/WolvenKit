using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionEvent : redEvent
	{
		[Ordinal(0)]  [RED("activator")] public wCHandle<gameObject> Activator { get; set; }
		[Ordinal(1)]  [RED("eventType")] public CEnum<gameinteractionsEInteractionEventType> EventType { get; set; }
		[Ordinal(2)]  [RED("hotspot")] public wCHandle<gameObject> Hotspot { get; set; }
		[Ordinal(3)]  [RED("layerData")] public gameinteractionsLayerData LayerData { get; set; }

		public gameinteractionsInteractionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
