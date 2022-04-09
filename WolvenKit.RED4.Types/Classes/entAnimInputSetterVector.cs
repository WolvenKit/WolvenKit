using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimInputSetterVector : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public Vector4 Value
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public entAnimInputSetterVector()
		{
			Value = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
