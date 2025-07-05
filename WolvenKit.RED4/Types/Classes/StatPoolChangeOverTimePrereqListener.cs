using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolChangeOverTimePrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<StatPoolChangeOverTimePrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<StatPoolChangeOverTimePrereqState>>();
			set => SetPropertyValue<CWeakHandle<StatPoolChangeOverTimePrereqState>>(value);
		}

		public StatPoolChangeOverTimePrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
