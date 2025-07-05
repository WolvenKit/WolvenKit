using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SUIScreenDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("screenDefinition")] 
		public TweakDBID ScreenDefinition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public TweakDBID Style
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public SUIScreenDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
