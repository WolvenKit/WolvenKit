using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventPostponedParameterCName : gamestateMachineeventPostponedParameterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
