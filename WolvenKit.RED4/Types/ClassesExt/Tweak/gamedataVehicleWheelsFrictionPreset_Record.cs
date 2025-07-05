
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelsFrictionPreset_Record
	{
		[RED("audioMaterialCoeff")]
		[REDProperty(IsIgnored = true)]
		public CFloat AudioMaterialCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("frictionCurveSet")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> FrictionCurveSet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("frictionLatMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat FrictionLatMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("frictionLongMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat FrictionLongMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("looseSurfaceLatResistanceCoeff")]
		[REDProperty(IsIgnored = true)]
		public CFloat LooseSurfaceLatResistanceCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("looseSurfaceLatSpeedMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat LooseSurfaceLatSpeedMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("looseSurfaceLongDriveResistanceCoeff")]
		[REDProperty(IsIgnored = true)]
		public CFloat LooseSurfaceLongDriveResistanceCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("looseSurfaceLongNonDriveResistanceCoeff")]
		[REDProperty(IsIgnored = true)]
		public CFloat LooseSurfaceLongNonDriveResistanceCoeff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("looseSurfaceLongSpeedMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat LooseSurfaceLongSpeedMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
