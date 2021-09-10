using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LiftStatus : BaseDeviceStatus
	{
		[Ordinal(26)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
