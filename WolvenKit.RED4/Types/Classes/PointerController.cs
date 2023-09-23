using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PointerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("connectors")] 
		public CArray<inkWidgetReference> Connectors
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("centerButtonSlot")] 
		public inkWidgetReference CenterButtonSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("centerButton")] 
		public CWeakHandle<inkWidget> CenterButton
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PointerController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
