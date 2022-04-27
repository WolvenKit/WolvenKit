
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetTopThreatPersistance_Record
	{
		[RED("source")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Source
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
