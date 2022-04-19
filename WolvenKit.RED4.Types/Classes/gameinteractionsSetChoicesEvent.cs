using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsSetChoicesEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("choices")] 
		public CArray<gameinteractionsChoice> Choices
		{
			get => GetPropertyValue<CArray<gameinteractionsChoice>>();
			set => SetPropertyValue<CArray<gameinteractionsChoice>>(value);
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsSetChoicesEvent()
		{
			Choices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
