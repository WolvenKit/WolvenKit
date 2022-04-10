using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TextSpawnerController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("amountOfRows")] 
		public CInt32 AmountOfRows
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("lineTextWidgetID")] 
		public CName LineTextWidgetID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("texts")] 
		public CArray<CWeakHandle<inkWidget>> Texts
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		public TextSpawnerController()
		{
			AmountOfRows = 6;
			Texts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
