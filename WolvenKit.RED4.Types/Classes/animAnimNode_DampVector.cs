using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_DampVector : animAnimNode_VectorValue
	{
		private Vector4 _defaultIncreaseSpeed;
		private Vector4 _defaultDecreaseSpeed;
		private CBool _startFromDefaultValue;
		private Vector4 _defaultInitialValue;
		private animVectorLink _inputNode;
		private animVectorLink _increaseSpeedNode;
		private animVectorLink _decreaseSpeedNode;

		[Ordinal(11)] 
		[RED("defaultIncreaseSpeed")] 
		public Vector4 DefaultIncreaseSpeed
		{
			get => GetProperty(ref _defaultIncreaseSpeed);
			set => SetProperty(ref _defaultIncreaseSpeed, value);
		}

		[Ordinal(12)] 
		[RED("defaultDecreaseSpeed")] 
		public Vector4 DefaultDecreaseSpeed
		{
			get => GetProperty(ref _defaultDecreaseSpeed);
			set => SetProperty(ref _defaultDecreaseSpeed, value);
		}

		[Ordinal(13)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetProperty(ref _startFromDefaultValue);
			set => SetProperty(ref _startFromDefaultValue, value);
		}

		[Ordinal(14)] 
		[RED("defaultInitialValue")] 
		public Vector4 DefaultInitialValue
		{
			get => GetProperty(ref _defaultInitialValue);
			set => SetProperty(ref _defaultInitialValue, value);
		}

		[Ordinal(15)] 
		[RED("inputNode")] 
		public animVectorLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(16)] 
		[RED("increaseSpeedNode")] 
		public animVectorLink IncreaseSpeedNode
		{
			get => GetProperty(ref _increaseSpeedNode);
			set => SetProperty(ref _increaseSpeedNode, value);
		}

		[Ordinal(17)] 
		[RED("decreaseSpeedNode")] 
		public animVectorLink DecreaseSpeedNode
		{
			get => GetProperty(ref _decreaseSpeedNode);
			set => SetProperty(ref _decreaseSpeedNode, value);
		}
	}
}
