
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadMembersAmountCheck_Record
	{
		[RED("countSelf")]
		[REDProperty(IsIgnored = true)]
		public CBool CountSelf
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxAmount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minAmount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinAmount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
