
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDodgeCountCond_Record
	{
		[RED("maxDodgeCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxDodgeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minDodgeCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinDodgeCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("OwnerAttackDodgedCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OwnerAttackDodgedCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
