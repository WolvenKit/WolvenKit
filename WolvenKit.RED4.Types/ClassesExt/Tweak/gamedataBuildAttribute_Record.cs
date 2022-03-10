
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildAttribute_Record
	{
		[RED("attribute")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attribute
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("level")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
