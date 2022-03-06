
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildProficiency_Record
	{
		[RED("level")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("proficiency")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Proficiency
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
