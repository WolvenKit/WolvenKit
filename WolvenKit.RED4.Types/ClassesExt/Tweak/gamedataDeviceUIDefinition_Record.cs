
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDeviceUIDefinition_Record
	{
		[RED("computerScreenType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ComputerScreenType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("terminalScreenType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TerminalScreenType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
