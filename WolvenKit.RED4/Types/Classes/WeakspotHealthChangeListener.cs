using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakspotHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("self")] 
		public CWeakHandle<gameObject> Self
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(2)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		public WeakspotHealthChangeListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
