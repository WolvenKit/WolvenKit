using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventPostponedParameterBase : gamestateMachineeventBaseEvent
	{
		[Ordinal(1)] 
		[RED("aspect")] 
		public CEnum<gamestateMachineParameterAspect> Aspect
		{
			get => GetPropertyValue<CEnum<gamestateMachineParameterAspect>>();
			set => SetPropertyValue<CEnum<gamestateMachineParameterAspect>>(value);
		}
	}
}
