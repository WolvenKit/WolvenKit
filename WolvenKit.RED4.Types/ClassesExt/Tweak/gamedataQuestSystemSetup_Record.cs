
namespace WolvenKit.RED4.Types
{
	public partial class gamedataQuestSystemSetup_Record
	{
		[RED("contentTokenMinimalCooldownWhenBlocking")]
		[REDProperty(IsIgnored = true)]
		public CFloat ContentTokenMinimalCooldownWhenBlocking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("contentTokenSpawnMaxCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat ContentTokenSpawnMaxCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("contentTokenSpawnMinCooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat ContentTokenSpawnMinCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("contentTokenStackMaxSize")]
		[REDProperty(IsIgnored = true)]
		public CInt32 ContentTokenStackMaxSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("customTooltipActions")]
		[REDProperty(IsIgnored = true)]
		public CArray<CString> CustomTooltipActions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}
	}
}
