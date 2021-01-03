using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileBroadPhaseHitEvent : redEvent
	{
		[Ordinal(0)]  [RED("hitComponent")] public wCHandle<entIComponent> HitComponent { get; set; }
		[Ordinal(1)]  [RED("hitObject")] public wCHandle<entEntity> HitObject { get; set; }
		[Ordinal(2)]  [RED("position")] public Vector4 Position { get; set; }
		[Ordinal(3)]  [RED("traceResult")] public physicsTraceResult TraceResult { get; set; }

		public gameprojectileBroadPhaseHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
