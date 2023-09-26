using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeArcadeObjectController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("image")] 
		public inkWidgetReference Image
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("colliderList")] 
		public CArray<gameuiarcadeArcadeColliderData> ColliderList
		{
			get => GetPropertyValue<CArray<gameuiarcadeArcadeColliderData>>();
			set => SetPropertyValue<CArray<gameuiarcadeArcadeColliderData>>(value);
		}

		public gameuiarcadeArcadeObjectController()
		{
			Image = new inkWidgetReference();
			ColliderList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
