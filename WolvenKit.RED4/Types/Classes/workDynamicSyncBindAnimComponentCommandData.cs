using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workDynamicSyncBindAnimComponentCommandData : workSyncBindBaseCommandData
	{
		[Ordinal(0)] 
		[RED("slave")] 
		public CWeakHandle<entAnimationControllerComponent> Slave
		{
			get => GetPropertyValue<CWeakHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CWeakHandle<entAnimationControllerComponent>>(value);
		}

		public workDynamicSyncBindAnimComponentCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
