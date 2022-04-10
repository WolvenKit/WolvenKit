using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScrollingText : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("textArray")] 
		public CArray<CString> TextArray
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public ScrollingText()
		{
			TextArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
