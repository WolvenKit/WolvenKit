
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWorldMapZoomLevel_Record
	{
		[RED("canChangeFilters")]
		[REDProperty(IsIgnored = true)]
		public CBool CanChangeFilters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("fov")]
		[REDProperty(IsIgnored = true)]
		public CFloat Fov
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("iconScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat IconScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("mappinFilterGroups")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> MappinFilterGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("panSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat PanSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("rotation")]
		[REDProperty(IsIgnored = true)]
		public EulerAngles Rotation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}
		
		[RED("showDistricts")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowDistricts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showSubDistricts")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowSubDistricts
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("zoom")]
		[REDProperty(IsIgnored = true)]
		public CFloat Zoom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
