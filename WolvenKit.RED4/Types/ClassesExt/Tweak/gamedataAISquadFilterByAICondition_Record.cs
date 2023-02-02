
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadFilterByAICondition_Record
	{
		[RED("condition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Condition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
