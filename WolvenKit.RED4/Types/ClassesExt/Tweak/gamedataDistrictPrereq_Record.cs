
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDistrictPrereq_Record
	{
		[RED("district")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID District
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
