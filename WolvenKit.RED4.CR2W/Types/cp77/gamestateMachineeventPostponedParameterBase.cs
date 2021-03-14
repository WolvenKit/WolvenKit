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
			get
			{
				if (_aspect == null)
				{
					_aspect = (CEnum<gamestateMachineParameterAspect>) CR2WTypeManager.Create("gamestateMachineParameterAspect", "aspect", cr2w, this);
				}
				return _aspect;
			}
			set
			{
				if (_aspect == value)
				{
					return;
				}
				_aspect = value;
				PropertySet(this);
			}
		}

		public gamestateMachineeventPostponedParameterBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
