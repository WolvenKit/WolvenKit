
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankPickupSpawnerData_Record
	{
		[RED("pickupList")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> PickupList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
