using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPhase : animAnimEvent
	{
		private CEnum<animEFootPhase> _phase;

		[Ordinal(3)] 
		[RED("phase")] 
		public CEnum<animEFootPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<animEFootPhase>) CR2WTypeManager.Create("animEFootPhase", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_FootPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
