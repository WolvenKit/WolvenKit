using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FactTextGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("factTextArray")] 
		public CArray<FactTextStruct> FactTextArray
		{
			get => GetPropertyValue<CArray<FactTextStruct>>();
			set => SetPropertyValue<CArray<FactTextStruct>>(value);
		}

		public FactTextGameController()
		{
			FactTextArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
