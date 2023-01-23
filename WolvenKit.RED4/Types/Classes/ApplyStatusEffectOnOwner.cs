using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyStatusEffectOnOwner : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyStatusEffectOnOwner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
