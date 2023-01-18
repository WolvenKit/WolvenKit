
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAimAssistSettings_Record
	{
		[RED("light")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Light
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("off")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Off
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("standard")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Standard
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
