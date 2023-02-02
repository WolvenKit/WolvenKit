
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAITicketCheck_Record
	{
		[RED("optionalFastExit")]
		[REDProperty(IsIgnored = true)]
		public CBool OptionalFastExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
