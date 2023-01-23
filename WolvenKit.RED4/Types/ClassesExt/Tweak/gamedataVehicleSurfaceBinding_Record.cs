
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleSurfaceBinding_Record
	{
		[RED("frictionPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FrictionPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("surfaceType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SurfaceType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
