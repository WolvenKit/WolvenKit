using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceInputChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bdSystem")] 
		public CHandle<BraindanceSystem> BdSystem
		{
			get => GetPropertyValue<CHandle<BraindanceSystem>>();
			set => SetPropertyValue<CHandle<BraindanceSystem>>(value);
		}

		public BraindanceInputChangeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
