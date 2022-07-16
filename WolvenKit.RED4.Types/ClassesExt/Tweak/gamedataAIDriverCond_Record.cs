
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDriverCond_Record
	{
		[RED("driver")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Driver
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
