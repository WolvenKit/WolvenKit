using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OvershieldMinValueListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<ScaleOvershieldDecayOverTimeEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<ScaleOvershieldDecayOverTimeEffector>>();
			set => SetPropertyValue<CWeakHandle<ScaleOvershieldDecayOverTimeEffector>>(value);
		}

		public OvershieldMinValueListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
