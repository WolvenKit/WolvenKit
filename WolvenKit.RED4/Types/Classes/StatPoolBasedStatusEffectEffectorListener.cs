using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolBasedStatusEffectEffectorListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<StatPoolBasedStatusEffectEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<StatPoolBasedStatusEffectEffector>>();
			set => SetPropertyValue<CWeakHandle<StatPoolBasedStatusEffectEffector>>(value);
		}

		public StatPoolBasedStatusEffectEffectorListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
