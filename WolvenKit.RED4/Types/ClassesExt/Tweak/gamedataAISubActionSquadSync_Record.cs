
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSquadSync_Record
	{
		[RED("pull")]
		[REDProperty(IsIgnored = true)]
		public CBool Pull
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("squadType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SquadType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
