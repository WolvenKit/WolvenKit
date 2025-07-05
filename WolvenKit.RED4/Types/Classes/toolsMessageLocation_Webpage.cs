using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessageLocation_Webpage : toolsIMessageLocation
	{
		[Ordinal(0)] 
		[RED("link")] 
		public CString Link
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public toolsMessageLocation_Webpage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
