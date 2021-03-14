using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameTimePrereqState : gamePrereqState
	{
		private CUInt32 _listener;

		[Ordinal(0)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get
			{
				if (_listener == null)
				{
					_listener = (CUInt32) CR2WTypeManager.Create("Uint32", "listener", cr2w, this);
				}
				return _listener;
			}
			set
			{
				if (_listener == value)
				{
					return;
				}
				_listener = value;
				PropertySet(this);
			}
		}

		public GameTimePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
