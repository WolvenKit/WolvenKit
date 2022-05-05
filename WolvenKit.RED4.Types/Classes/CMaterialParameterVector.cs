using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterVector : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("vector")] 
		public Vector4 Vector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public CMaterialParameterVector()
		{
			Vector = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
