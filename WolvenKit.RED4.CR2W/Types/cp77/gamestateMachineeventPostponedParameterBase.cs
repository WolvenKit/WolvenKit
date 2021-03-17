using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventPostponedParameterBase : gamestateMachineeventBaseEvent
	{
		private CEnum<gamestateMachineParameterAspect> _aspect;

		[Ordinal(1)] 
		[RED("aspect")] 
		public CEnum<gamestateMachineParameterAspect> Aspect
		{
			get => GetProperty(ref _aspect);
			set => SetProperty(ref _aspect, value);
		}

		public gamestateMachineeventPostponedParameterBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
