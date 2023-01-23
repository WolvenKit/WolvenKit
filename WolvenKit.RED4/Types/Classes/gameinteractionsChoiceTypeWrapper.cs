using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceTypeWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("properties")] 
		public CUInt32 Properties
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameinteractionsChoiceTypeWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
