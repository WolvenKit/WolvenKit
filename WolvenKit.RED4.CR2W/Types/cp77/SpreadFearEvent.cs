using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadFearEvent : redEvent
	{
		private CBool _player;
		private CInt32 _phase;

		[Ordinal(0)] 
		[RED("player")] 
		public CBool Player
		{
			get
			{
				if (_player == null)
				{
					_player = (CBool) CR2WTypeManager.Create("Bool", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CInt32 Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CInt32) CR2WTypeManager.Create("Int32", "phase", cr2w, this);
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

		public SpreadFearEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
