using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactEvent : redEvent
	{
		private wCHandle<entEntity> _otherEntity;
		private CBool _triggeredSimulation;
		private CArray<entRagdollImpactPointData> _impactPoints;

		[Ordinal(0)] 
		[RED("otherEntity")] 
		public wCHandle<entEntity> OtherEntity
		{
			get => GetProperty(ref _otherEntity);
			set => SetProperty(ref _otherEntity, value);
		}

		[Ordinal(1)] 
		[RED("triggeredSimulation")] 
		public CBool TriggeredSimulation
		{
			get => GetProperty(ref _triggeredSimulation);
			set => SetProperty(ref _triggeredSimulation, value);
		}

		[Ordinal(2)] 
		[RED("impactPoints")] 
		public CArray<entRagdollImpactPointData> ImpactPoints
		{
			get => GetProperty(ref _impactPoints);
			set => SetProperty(ref _impactPoints, value);
		}

		public entRagdollImpactEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
