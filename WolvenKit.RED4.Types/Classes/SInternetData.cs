using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SInternetData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startingPage")] 
		public CString StartingPage
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SInternetData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
