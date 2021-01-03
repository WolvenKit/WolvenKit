using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactEvent : redEvent
	{
		[Ordinal(0)]  [RED("impactPoints")] public CArray<entRagdollImpactPointData> ImpactPoints { get; set; }
		[Ordinal(1)]  [RED("otherEntity")] public wCHandle<entEntity> OtherEntity { get; set; }
		[Ordinal(2)]  [RED("triggeredSimulation")] public CBool TriggeredSimulation { get; set; }

		public entRagdollImpactEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
