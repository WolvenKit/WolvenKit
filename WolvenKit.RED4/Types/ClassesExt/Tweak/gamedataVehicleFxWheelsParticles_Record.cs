
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFxWheelsParticles_Record
	{
		[RED("materials")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Materials
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("rain_material_overrides")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Rain_material_overrides
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("wet_material_overrides")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Wet_material_overrides
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
