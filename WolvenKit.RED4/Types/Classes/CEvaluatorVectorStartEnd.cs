using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorVectorStartEnd : IEvaluatorVector
	{
		[Ordinal(2)] 
		[RED("start")] 
		public Vector4 Start
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("end")] 
		public Vector4 End
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public CEvaluatorVectorStartEnd()
		{
			FreeAxes = Enums.EFreeVectorAxes.FVA_Three;
			Spill = true;
			Start = new();
			End = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
