using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WardrobeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("clothingSets")] 
		public CArray<ClothingSet> ClothingSets
		{
			get => GetPropertyValue<CArray<ClothingSet>>();
			set => SetPropertyValue<CArray<ClothingSet>>(value);
		}

		public WardrobeControllerPS()
		{
			DeviceName = "LocKey#2120";
			TweakDBRecord = new() { Value = 70419249436 };
			ClothingSets = new();
		}
	}
}
