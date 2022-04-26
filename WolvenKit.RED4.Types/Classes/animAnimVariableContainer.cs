using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("boolVariables")] 
		public CArray<CHandle<animAnimVariableBool>> BoolVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableBool>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableBool>>>(value);
		}

		[Ordinal(1)] 
		[RED("intVariables")] 
		public CArray<CHandle<animAnimVariableInt>> IntVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableInt>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableInt>>>(value);
		}

		[Ordinal(2)] 
		[RED("floatVariables")] 
		public CArray<CHandle<animAnimVariableFloat>> FloatVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableFloat>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableFloat>>>(value);
		}

		[Ordinal(3)] 
		[RED("vectorVariables")] 
		public CArray<CHandle<animAnimVariableVector>> VectorVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableVector>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableVector>>>(value);
		}

		[Ordinal(4)] 
		[RED("quaternionVariables")] 
		public CArray<CHandle<animAnimVariableQuaternion>> QuaternionVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableQuaternion>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableQuaternion>>>(value);
		}

		[Ordinal(5)] 
		[RED("transformVariables")] 
		public CArray<CHandle<animAnimVariableTransform>> TransformVariables
		{
			get => GetPropertyValue<CArray<CHandle<animAnimVariableTransform>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimVariableTransform>>>(value);
		}

		public animAnimVariableContainer()
		{
			BoolVariables = new();
			IntVariables = new();
			FloatVariables = new();
			VectorVariables = new();
			QuaternionVariables = new();
			TransformVariables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
