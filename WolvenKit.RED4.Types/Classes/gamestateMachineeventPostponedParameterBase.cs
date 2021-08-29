using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineeventPostponedParameterBase : gamestateMachineeventBaseEvent
	{
		private CEnum<gamestateMachineParameterAspect> _aspect;

		[Ordinal(1)] 
		[RED("aspect")] 
		public CEnum<gamestateMachineParameterAspect> Aspect
		{
			get => GetProperty(ref _aspect);
			set => SetProperty(ref _aspect, value);
		}
	}
}
