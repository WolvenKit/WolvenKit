using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		private CHandle<AnimFeature_StatusEffect> _animFeatureStatusEffect;

		[Ordinal(6)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetProperty(ref _animFeatureStatusEffect);
			set => SetProperty(ref _animFeatureStatusEffect, value);
		}

		public CollisionExitingEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
