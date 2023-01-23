using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDInstruction : redEvent
	{
		[Ordinal(0)] 
		[RED("scannerInstructions")] 
		public CHandle<ScanInstance> ScannerInstructions
		{
			get => GetPropertyValue<CHandle<ScanInstance>>();
			set => SetPropertyValue<CHandle<ScanInstance>>(value);
		}

		[Ordinal(1)] 
		[RED("highlightInstructions")] 
		public CHandle<HighlightInstance> HighlightInstructions
		{
			get => GetPropertyValue<CHandle<HighlightInstance>>();
			set => SetPropertyValue<CHandle<HighlightInstance>>(value);
		}

		[Ordinal(2)] 
		[RED("braindanceInstructions")] 
		public CHandle<BraindanceInstance> BraindanceInstructions
		{
			get => GetPropertyValue<CHandle<BraindanceInstance>>();
			set => SetPropertyValue<CHandle<BraindanceInstance>>(value);
		}

		[Ordinal(3)] 
		[RED("iconsInstruction")] 
		public CHandle<IconsInstance> IconsInstruction
		{
			get => GetPropertyValue<CHandle<IconsInstance>>();
			set => SetPropertyValue<CHandle<IconsInstance>>(value);
		}

		[Ordinal(4)] 
		[RED("quickhackInstruction")] 
		public CHandle<QuickhackInstance> QuickhackInstruction
		{
			get => GetPropertyValue<CHandle<QuickhackInstance>>();
			set => SetPropertyValue<CHandle<QuickhackInstance>>(value);
		}

		public HUDInstruction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
