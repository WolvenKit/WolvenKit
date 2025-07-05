using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class IEvaluatorVector : IEvaluator
	{
		[Ordinal(0)] 
		[RED("freeAxes")] 
		public CEnum<EFreeVectorAxes> FreeAxes
		{
			get => GetPropertyValue<CEnum<EFreeVectorAxes>>();
			set => SetPropertyValue<CEnum<EFreeVectorAxes>>(value);
		}

		[Ordinal(1)] 
		[RED("spill")] 
		public CBool Spill
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IEvaluatorVector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
