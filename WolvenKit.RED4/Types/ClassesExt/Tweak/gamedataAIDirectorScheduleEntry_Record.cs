
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIDirectorScheduleEntry_Record
	{
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("entryStartType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EntryStartType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("killsLimit")]
		[REDProperty(IsIgnored = true)]
		public CInt32 KillsLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("plans")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Plans
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tensionDelta")]
		[REDProperty(IsIgnored = true)]
		public CFloat TensionDelta
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
