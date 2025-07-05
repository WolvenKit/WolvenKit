using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiarcadeArcadePlayerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("colliderList")] 
		public CArray<gameuiarcadeArcadeColliderData> ColliderList
		{
			get => GetPropertyValue<CArray<gameuiarcadeArcadeColliderData>>();
			set => SetPropertyValue<CArray<gameuiarcadeArcadeColliderData>>(value);
		}

		public gameuiarcadeArcadePlayerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
