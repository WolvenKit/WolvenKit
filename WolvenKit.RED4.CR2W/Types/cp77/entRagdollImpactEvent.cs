using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactEvent : redEvent
	{
		[Ordinal(0)] [RED("otherEntity")] public wCHandle<entEntity> OtherEntity { get; set; }
		[Ordinal(1)] [RED("triggeredSimulation")] public CBool TriggeredSimulation { get; set; }
		[Ordinal(2)] [RED("impactPoints")] public CArray<entRagdollImpactPointData> ImpactPoints { get; set; }

		public entRagdollImpactEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
