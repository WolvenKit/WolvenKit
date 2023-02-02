
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionHitData_Record
	{
		[RED("directionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DirectionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("overrideHitDirection")]
		[REDProperty(IsIgnored = true)]
		public CBool OverrideHitDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
