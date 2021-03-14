using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCAttitudeTowardsPlayerPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqAttitudeListenerWrapper> _attitudeListener;

		[Ordinal(0)] 
		[RED("attitudeListener")] 
		public CHandle<gameScriptedPrereqAttitudeListenerWrapper> AttitudeListener
		{
			get
			{
				if (_attitudeListener == null)
				{
					_attitudeListener = (CHandle<gameScriptedPrereqAttitudeListenerWrapper>) CR2WTypeManager.Create("handle:gameScriptedPrereqAttitudeListenerWrapper", "attitudeListener", cr2w, this);
				}
				return _attitudeListener;
			}
			set
			{
				if (_attitudeListener == value)
				{
					return;
				}
				_attitudeListener = value;
				PropertySet(this);
			}
		}

		public NPCAttitudeTowardsPlayerPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
