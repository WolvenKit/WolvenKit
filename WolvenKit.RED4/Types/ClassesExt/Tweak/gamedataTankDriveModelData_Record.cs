
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankDriveModelData_Record
	{
		[RED("tankAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOD")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOD
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOI")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOI
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOP")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOP
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankDeceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankDeceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankGravityMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankGravityMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringDamping")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringsLocalPositions")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector2> TankSpringsLocalPositions
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}
		
		[RED("tankSpringStiffness")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringVerticalOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringVerticalOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankTurningSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankTurningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
