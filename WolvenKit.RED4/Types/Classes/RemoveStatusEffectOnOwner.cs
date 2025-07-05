using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveStatusEffectOnOwner : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public RemoveStatusEffectOnOwner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
