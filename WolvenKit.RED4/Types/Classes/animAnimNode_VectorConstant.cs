using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_VectorConstant : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimNode_VectorConstant()
		{
			Id = 4294967295;
			Value = new() { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
