using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class senseVisibilityEvent : redEvent
	{
		[Ordinal(0)]  [RED("description")] public CName Description { get; set; }
		[Ordinal(1)]  [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)]  [RED("shapeId")] public TweakDBID ShapeId { get; set; }
		[Ordinal(3)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public senseVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
