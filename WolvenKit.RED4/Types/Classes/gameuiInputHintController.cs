using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("inputDisplayLibRef")] 
		public inkWidgetLibraryReference InputDisplayLibRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(2)] 
		[RED("inputDisplayContainer")] 
		public inkCompoundWidgetReference InputDisplayContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("textWidgetRef")] 
		public inkTextWidgetReference TextWidgetRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public gameuiInputHintController()
		{
			InputDisplayLibRef = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };
			InputDisplayContainer = new inkCompoundWidgetReference();
			TextWidgetRef = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
