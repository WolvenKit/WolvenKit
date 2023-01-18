
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFxWheelsParticlesMaterial_Record
	{
		[RED("material")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Material
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("skid_marks_particles")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Skid_marks_particles
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("tire_tracks_particles")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Tire_tracks_particles
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
