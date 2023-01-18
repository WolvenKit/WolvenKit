
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStreetCredTier_Record
	{
		[RED("streetCredRequirement")]
		[REDProperty(IsIgnored = true)]
		public CInt32 StreetCredRequirement
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
