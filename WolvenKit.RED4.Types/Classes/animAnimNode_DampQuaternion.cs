using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_DampQuaternion : animAnimNode_QuaternionValue
	{
		private CFloat _defaultRotationSpeed;
		private EulerAngles _defaultInitialValue;
		private animQuaternionLink _inputNode;
		private animQuaternionLink _initialValueNode;
		private animFloatLink _rotationSpeedNode;

		[Ordinal(11)] 
		[RED("defaultRotationSpeed")] 
		public CFloat DefaultRotationSpeed
		{
			get => GetProperty(ref _defaultRotationSpeed);
			set => SetProperty(ref _defaultRotationSpeed, value);
		}

		[Ordinal(12)] 
		[RED("defaultInitialValue")] 
		public EulerAngles DefaultInitialValue
		{
			get => GetProperty(ref _defaultInitialValue);
			set => SetProperty(ref _defaultInitialValue, value);
		}

		[Ordinal(13)] 
		[RED("inputNode")] 
		public animQuaternionLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(14)] 
		[RED("initialValueNode")] 
		public animQuaternionLink InitialValueNode
		{
			get => GetProperty(ref _initialValueNode);
			set => SetProperty(ref _initialValueNode, value);
		}

		[Ordinal(15)] 
		[RED("rotationSpeedNode")] 
		public animFloatLink RotationSpeedNode
		{
			get => GetProperty(ref _rotationSpeedNode);
			set => SetProperty(ref _rotationSpeedNode, value);
		}

		public animAnimNode_DampQuaternion()
		{
			_defaultRotationSpeed = 180.000000F;
		}
	}
}
