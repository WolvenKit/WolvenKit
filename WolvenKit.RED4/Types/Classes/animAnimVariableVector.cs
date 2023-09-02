using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableVector : animAnimVariable
	{
		[Ordinal(2)] 
		[RED("x")] 
		public CFloat X
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("y")] 
		public CFloat Y
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("z")] 
		public CFloat Z
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("w")] 
		public CFloat W
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("default")] 
		public Vector4 Default
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("min")] 
		public Vector4 Min
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("max")] 
		public Vector4 Max
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimVariableVector()
		{
			W = 1.000000F;
			Default = new Vector4 { W = 1.000000F };
			Min = new Vector4 { X = float.MinValue, Y = float.MinValue, Z = float.MinValue, W = float.MinValue };
			Max = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
