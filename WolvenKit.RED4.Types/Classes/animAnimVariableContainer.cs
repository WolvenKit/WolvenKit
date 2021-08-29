using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableContainer : ISerializable
	{
		private CArray<CHandle<animAnimVariableBool>> _boolVariables;
		private CArray<CHandle<animAnimVariableInt>> _intVariables;
		private CArray<CHandle<animAnimVariableFloat>> _floatVariables;
		private CArray<CHandle<animAnimVariableVector>> _vectorVariables;
		private CArray<CHandle<animAnimVariableQuaternion>> _quaternionVariables;
		private CArray<CHandle<animAnimVariableTransform>> _transformVariables;

		[Ordinal(0)] 
		[RED("boolVariables")] 
		public CArray<CHandle<animAnimVariableBool>> BoolVariables
		{
			get => GetProperty(ref _boolVariables);
			set => SetProperty(ref _boolVariables, value);
		}

		[Ordinal(1)] 
		[RED("intVariables")] 
		public CArray<CHandle<animAnimVariableInt>> IntVariables
		{
			get => GetProperty(ref _intVariables);
			set => SetProperty(ref _intVariables, value);
		}

		[Ordinal(2)] 
		[RED("floatVariables")] 
		public CArray<CHandle<animAnimVariableFloat>> FloatVariables
		{
			get => GetProperty(ref _floatVariables);
			set => SetProperty(ref _floatVariables, value);
		}

		[Ordinal(3)] 
		[RED("vectorVariables")] 
		public CArray<CHandle<animAnimVariableVector>> VectorVariables
		{
			get => GetProperty(ref _vectorVariables);
			set => SetProperty(ref _vectorVariables, value);
		}

		[Ordinal(4)] 
		[RED("quaternionVariables")] 
		public CArray<CHandle<animAnimVariableQuaternion>> QuaternionVariables
		{
			get => GetProperty(ref _quaternionVariables);
			set => SetProperty(ref _quaternionVariables, value);
		}

		[Ordinal(5)] 
		[RED("transformVariables")] 
		public CArray<CHandle<animAnimVariableTransform>> TransformVariables
		{
			get => GetProperty(ref _transformVariables);
			set => SetProperty(ref _transformVariables, value);
		}
	}
}
