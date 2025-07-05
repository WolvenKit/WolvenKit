using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudMilitechWarningGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public hudMilitechWarningGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
