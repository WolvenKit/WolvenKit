
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFxCollisionMaterial_Record
	{
		[RED("impact_decal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Impact_decal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("impact_particles")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Impact_particles
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("material")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Material
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("scratch_decal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Scratch_decal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("scratch_particles")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Scratch_particles
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
