
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUISettings_Record
	{
		[RED("completedPOIOpacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat CompletedPOIOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("showInTier3")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowInTier3
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
