using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(25)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("psmBB")] 
		public CWeakHandle<gameIBlackboard> PsmBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("qsdBB")] 
		public CWeakHandle<gameIBlackboard> QsdBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(28)] 
		[RED("bbListener")] 
		public CHandle<redCallbackObject> BbListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("radialListener")] 
		public CHandle<redCallbackObject> RadialListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CarHotkeyController()
		{
			HotkeyBackground = new inkImageWidgetReference();
			ButtonHint = new inkWidgetReference();
			Restrictions = new();
			DebugCommands = new();
			CarIconSlot = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
