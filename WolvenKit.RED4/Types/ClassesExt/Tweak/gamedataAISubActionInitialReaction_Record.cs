
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionInitialReaction_Record
	{
		[RED("directionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DirectionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
