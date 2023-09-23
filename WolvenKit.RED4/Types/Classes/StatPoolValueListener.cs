using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolValueListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("effector")] 
		public CWeakHandle<StatPoolBasedTimeBankEffector> Effector
		{
			get => GetPropertyValue<CWeakHandle<StatPoolBasedTimeBankEffector>>();
			set => SetPropertyValue<CWeakHandle<StatPoolBasedTimeBankEffector>>(value);
		}

		public StatPoolValueListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
