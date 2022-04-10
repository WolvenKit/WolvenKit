using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		[Ordinal(2)] 
		[RED("min")] 
		public Vector4 Min
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("max")] 
		public Vector4 Max
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("lockX")] 
		public CBool LockX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("lockY")] 
		public CBool LockY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("lockZ")] 
		public CBool LockZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("lockW")] 
		public CBool LockW
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CEvaluatorVectorRandomUniform()
		{
			FreeAxes = Enums.EFreeVectorAxes.FVA_Three;
			Spill = true;
			Min = new();
			Max = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
