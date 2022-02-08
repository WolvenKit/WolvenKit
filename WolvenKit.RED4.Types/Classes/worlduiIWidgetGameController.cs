using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worlduiIWidgetGameController : inkIWidgetController
	{
		[Ordinal(1)] 
		[RED("elementRecordID")] 
		public TweakDBID ElementRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
