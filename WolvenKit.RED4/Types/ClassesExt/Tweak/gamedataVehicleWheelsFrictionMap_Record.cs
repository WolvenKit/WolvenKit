
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelsFrictionMap_Record
	{
		[RED("defaultFrictionPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DefaultFrictionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("surfaces")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Surfaces
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
