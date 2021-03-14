using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsNpcMountedInSlotPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqPSChangeListenerWrapper> _psListener;

		[Ordinal(0)] 
		[RED("psListener")] 
		public CHandle<gameScriptedPrereqPSChangeListenerWrapper> PsListener
		{
			get
			{
				if (_psListener == null)
				{
					_psListener = (CHandle<gameScriptedPrereqPSChangeListenerWrapper>) CR2WTypeManager.Create("handle:gameScriptedPrereqPSChangeListenerWrapper", "psListener", cr2w, this);
				}
				return _psListener;
			}
			set
			{
				if (_psListener == value)
				{
					return;
				}
				_psListener = value;
				PropertySet(this);
			}
		}

		public IsNpcMountedInSlotPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
