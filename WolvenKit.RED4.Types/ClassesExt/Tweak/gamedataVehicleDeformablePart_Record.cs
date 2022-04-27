
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDeformablePart_Record
	{
		[RED("component")]
		[REDProperty(IsIgnored = true)]
		public CName Component
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("zones")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Zones
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
