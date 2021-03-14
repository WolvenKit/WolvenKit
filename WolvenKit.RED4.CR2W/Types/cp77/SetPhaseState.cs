using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetPhaseState : AIActionHelperTask
	{
		private CEnum<ENPCPhaseState> _phaseStateValue;

		[Ordinal(5)] 
		[RED("phaseStateValue")] 
		public CEnum<ENPCPhaseState> PhaseStateValue
		{
			get
			{
				if (_phaseStateValue == null)
				{
					_phaseStateValue = (CEnum<ENPCPhaseState>) CR2WTypeManager.Create("ENPCPhaseState", "phaseStateValue", cr2w, this);
				}
				return _phaseStateValue;
			}
			set
			{
				if (_phaseStateValue == value)
				{
					return;
				}
				_phaseStateValue = value;
				PropertySet(this);
			}
		}

		public SetPhaseState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
