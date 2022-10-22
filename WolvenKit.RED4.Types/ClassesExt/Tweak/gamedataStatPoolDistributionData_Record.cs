
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatPoolDistributionData_Record
	{
		[RED("statPoolType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPoolType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
