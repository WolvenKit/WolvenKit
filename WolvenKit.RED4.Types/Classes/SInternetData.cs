using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SInternetData : RedBaseClass
	{
		private CString _startingPage;

		[Ordinal(0)] 
		[RED("startingPage")] 
		public CString StartingPage
		{
			get => GetProperty(ref _startingPage);
			set => SetProperty(ref _startingPage, value);
		}
	}
}
