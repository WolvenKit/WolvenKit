
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModePose_Record
	{
		[RED("acceptedWeaponConfig")]
		[REDProperty(IsIgnored = true)]
		public CName AcceptedWeaponConfig
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("allowMoveUpDown")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowMoveUpDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("animationName")]
		[REDProperty(IsIgnored = true)]
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("category")]
		[REDProperty(IsIgnored = true)]
		public CName Category
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("disableLookAtForGarmentTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> DisableLookAtForGarmentTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("filterOutForGarmentTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> FilterOutForGarmentTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("lookAtPreset")]
		[REDProperty(IsIgnored = true)]
		public CName LookAtPreset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("poseSize")]
		[REDProperty(IsIgnored = true)]
		public CFloat PoseSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("poseStateConfig")]
		[REDProperty(IsIgnored = true)]
		public CName PoseStateConfig
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("positionOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 PositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
