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

		public gameuiarcadeArcadeObjectController()
		{
			Image = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
