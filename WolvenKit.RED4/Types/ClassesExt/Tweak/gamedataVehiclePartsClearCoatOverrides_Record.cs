
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehiclePartsClearCoatOverrides_Record
	{
		[RED("overrides")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Overrides
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("partsName")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> PartsName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
