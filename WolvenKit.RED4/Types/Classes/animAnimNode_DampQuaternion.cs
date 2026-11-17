using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] 
		[RED("defaultRotationSpeed")] 
		public CFloat DefaultRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("defaultInitialValue")] 
		public EulerAngles DefaultInitialValue
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(3)] 
		[RED("inputNode")] 
		public animQuaternionLink InputNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(4)] 
		[RED("initialValueNode")] 
		public animQuaternionLink InitialValueNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(5)] 
		[RED("rotationSpeedNode")] 
		public animFloatLink RotationSpeedNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_DampQuaternion()
		{
			Id = uint.MaxValue;
			DefaultRotationSpeed = 180.000000F;
			DefaultInitialValue = new EulerAngles();
			InputNode = new animQuaternionLink();
			InitialValueNode = new animQuaternionLink();
			RotationSpeedNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
