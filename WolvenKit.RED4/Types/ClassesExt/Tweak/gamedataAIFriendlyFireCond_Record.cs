
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIFriendlyFireCond_Record
	{
		[RED("checkPlayer")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
