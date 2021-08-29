using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedeviceUIScreenDefinition : RedBaseClass
	{
		private TweakDBID _screenType;

		[Ordinal(0)] 
		[RED("screenType")] 
		public TweakDBID ScreenType
		{
			get => GetProperty(ref _screenType);
			set => SetProperty(ref _screenType, value);
		}
	}
}
