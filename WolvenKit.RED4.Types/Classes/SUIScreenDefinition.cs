using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SUIScreenDefinition : RedBaseClass
	{
		private TweakDBID _screenDefinition;
		private TweakDBID _style;

		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public TweakDBID ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public TweakDBID Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}
	}
}
