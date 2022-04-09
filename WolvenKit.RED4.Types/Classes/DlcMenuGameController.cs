using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DlcMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsRef")] 
		public inkWidgetReference ButtonHintsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("containersRef")] 
		public inkCompoundWidgetReference ContainersRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public DlcMenuGameController()
		{
			ButtonHintsRef = new();
			ContainersRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
