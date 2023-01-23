using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLineVertex : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("int")] 
		public Vector2 Int
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("neType")] 
		public CEnum<inkLineType> NeType
		{
			get => GetPropertyValue<CEnum<inkLineType>>();
			set => SetPropertyValue<CEnum<inkLineType>>(value);
		}

		public inkLineVertex()
		{
			Int = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
