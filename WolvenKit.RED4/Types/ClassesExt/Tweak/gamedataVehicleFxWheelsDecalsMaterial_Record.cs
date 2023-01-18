
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleFxWheelsDecalsMaterial_Record
	{
		[RED("material")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Material
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("skid_marks_decal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Skid_marks_decal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("tire_tracks_decal")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Tire_tracks_decal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
