using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanPlayerHijackMountedNpcPrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqMountingListenerWrapper> _mountingListener;

		[Ordinal(0)] 
		[RED("mountingListener")] 
		public CHandle<gameScriptedPrereqMountingListenerWrapper> MountingListener
		{
			get
			{
				if (_mountingListener == null)
				{
					_mountingListener = (CHandle<gameScriptedPrereqMountingListenerWrapper>) CR2WTypeManager.Create("handle:gameScriptedPrereqMountingListenerWrapper", "mountingListener", cr2w, this);
				}
				return _mountingListener;
			}
			set
			{
				if (_mountingListener == value)
				{
					return;
				}
				_mountingListener = value;
				PropertySet(this);
			}
		}

		public CanPlayerHijackMountedNpcPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
