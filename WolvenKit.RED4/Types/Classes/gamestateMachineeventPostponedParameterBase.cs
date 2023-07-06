using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gamestateMachineeventPostponedParameterBase : gamestateMachineeventBaseEvent
	{
		[Ordinal(1)] 
		[RED("aspect")] 
		public CEnum<gamestateMachineParameterAspect> Aspect
		{
			get => GetPropertyValue<CEnum<gamestateMachineParameterAspect>>();
			set => SetPropertyValue<CEnum<gamestateMachineParameterAspect>>(value);
		}

		public gamestateMachineeventPostponedParameterBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
