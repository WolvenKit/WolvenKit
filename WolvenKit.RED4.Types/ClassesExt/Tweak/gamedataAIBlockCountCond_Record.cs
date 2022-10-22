
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIBlockCountCond_Record
	{
		[RED("maxBlockCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxBlockCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("maxParryCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxParryCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minBlockCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinBlockCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("minParryCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MinParryCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("ownerAttackBlockedCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OwnerAttackBlockedCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("ownerAttackParriedCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OwnerAttackParriedCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
