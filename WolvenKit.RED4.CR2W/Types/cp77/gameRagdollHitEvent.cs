using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRagdollHitEvent : gameeventsHitEvent
	{
		private CFloat _impactForce;
		private CFloat _speedDelta;
		private CFloat _heightDelta;

		[Ordinal(12)] 
		[RED("impactForce")] 
		public CFloat ImpactForce
		{
			get => GetProperty(ref _impactForce);
			set => SetProperty(ref _impactForce, value);
		}

		[Ordinal(13)] 
		[RED("speedDelta")] 
		public CFloat SpeedDelta
		{
			get => GetProperty(ref _speedDelta);
			set => SetProperty(ref _speedDelta, value);
		}

		[Ordinal(14)] 
		[RED("heightDelta")] 
		public CFloat HeightDelta
		{
			get => GetProperty(ref _heightDelta);
			set => SetProperty(ref _heightDelta, value);
		}

		public gameRagdollHitEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
