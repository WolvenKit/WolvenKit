using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GateSchemeLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("sfxFactsSet")] 
		public SoundFxFactsSet SfxFactsSet
		{
			get => GetPropertyValue<SoundFxFactsSet>();
			set => SetPropertyValue<SoundFxFactsSet>(value);
		}

		[Ordinal(2)] 
		[RED("tube1")] 
		public inkWidgetReference Tube1
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("tube2")] 
		public inkWidgetReference Tube2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("tube3")] 
		public inkWidgetReference Tube3
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tube4")] 
		public inkWidgetReference Tube4
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("tube5")] 
		public inkWidgetReference Tube5
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("tube6")] 
		public inkWidgetReference Tube6
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("tube7")] 
		public inkWidgetReference Tube7
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("tube8")] 
		public inkWidgetReference Tube8
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("OpeningGateLeftAnimName")] 
		public CName OpeningGateLeftAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("OpeningGateRightAnimName")] 
		public CName OpeningGateRightAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("currentSystemIndex")] 
		public CInt32 CurrentSystemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public GateSchemeLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
