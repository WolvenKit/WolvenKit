using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPrereqListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<StatPrereqState>>();
			set => SetPropertyValue<CWeakHandle<StatPrereqState>>(value);
		}

		public StatPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
