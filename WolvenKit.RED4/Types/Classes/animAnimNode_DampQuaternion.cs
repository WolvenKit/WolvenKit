using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		[Ordinal(11)] 
		[RED("defaultRotationSpeed")] 
		public CFloat DefaultRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("defaultInitialValue")] 
		public EulerAngles DefaultInitialValue
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(13)] 
		[RED("inputNode")] 
		public animQuaternionLink InputNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(14)] 
		[RED("initialValueNode")] 
		public animQuaternionLink InitialValueNode
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(15)] 
		[RED("rotationSpeedNode")] 
		public animFloatLink RotationSpeedNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_DampQuaternion()
		{
			Id = 4294967295;
			DefaultRotationSpeed = 180.000000F;
			DefaultInitialValue = new();
			InputNode = new();
			InitialValueNode = new();
			RotationSpeedNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
