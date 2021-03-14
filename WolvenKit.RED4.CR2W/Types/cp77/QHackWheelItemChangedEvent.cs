using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QHackWheelItemChangedEvent : redEvent
	{
		private CHandle<QuickhackData> _commandData;
		private CBool _currentEmpty;

		[Ordinal(0)] 
		[RED("commandData")] 
		public CHandle<QuickhackData> CommandData
		{
			get
			{
				if (_commandData == null)
				{
					_commandData = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "commandData", cr2w, this);
				}
				return _commandData;
			}
			set
			{
				if (_commandData == value)
				{
					return;
				}
				_commandData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentEmpty")] 
		public CBool CurrentEmpty
		{
			get
			{
				if (_currentEmpty == null)
				{
					_currentEmpty = (CBool) CR2WTypeManager.Create("Bool", "currentEmpty", cr2w, this);
				}
				return _currentEmpty;
			}
			set
			{
				if (_currentEmpty == value)
				{
					return;
				}
				_currentEmpty = value;
				PropertySet(this);
			}
		}

		public QHackWheelItemChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
