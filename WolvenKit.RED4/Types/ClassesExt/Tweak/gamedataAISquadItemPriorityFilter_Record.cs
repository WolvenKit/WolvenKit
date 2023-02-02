
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadItemPriorityFilter_Record
	{
		[RED("restoreOnFail")]
		[REDProperty(IsIgnored = true)]
		public CBool RestoreOnFail
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
