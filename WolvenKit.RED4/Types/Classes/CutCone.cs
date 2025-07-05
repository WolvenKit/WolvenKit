using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class CutCone : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positionAndRadius1")] 
		public Vector4 PositionAndRadius1
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("normalAndRadius2")] 
		public Vector4 NormalAndRadius2
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CutCone()
		{
			PositionAndRadius1 = new Vector4();
			NormalAndRadius2 = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
