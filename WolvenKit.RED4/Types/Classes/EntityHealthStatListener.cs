using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityHealthStatListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<EntityHealthBarGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<EntityHealthBarGameController>>();
			set => SetPropertyValue<CWeakHandle<EntityHealthBarGameController>>(value);
		}

		public EntityHealthStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
