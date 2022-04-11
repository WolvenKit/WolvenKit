using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkIWidgetLogicController : IScriptable
	{
		[Ordinal(0)] 
		[RED("audioMetadataName")] 
		public CName AudioMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
