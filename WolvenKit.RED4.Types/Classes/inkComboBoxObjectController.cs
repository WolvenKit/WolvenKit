using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkComboBoxObjectController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("contentWidgetRef")] 
		public inkWidgetReference ContentWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("placeholderOffsetWidgetRef")] 
		public inkWidgetReference PlaceholderOffsetWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("colliderRef")] 
		public inkShapeWidgetReference ColliderRef
		{
			get => GetPropertyValue<inkShapeWidgetReference>();
			set => SetPropertyValue<inkShapeWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public inkMargin Offset
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public inkComboBoxObjectController()
		{
			ContentWidgetRef = new();
			PlaceholderOffsetWidgetRef = new();
			ColliderRef = new();
			Offset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
