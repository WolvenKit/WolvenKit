using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalChangeMappinPhase_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CEnum<gamedataMappinPhase> _phase;
		private CBool _notifyUI;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("phase")] 
		public CEnum<gamedataMappinPhase> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CEnum<gamedataMappinPhase>) CR2WTypeManager.Create("gamedataMappinPhase", "phase", cr2w, this);
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

		[Ordinal(2)] 
		[RED("notifyUI")] 
		public CBool NotifyUI
		{
			get
			{
				if (_notifyUI == null)
				{
					_notifyUI = (CBool) CR2WTypeManager.Create("Bool", "notifyUI", cr2w, this);
				}
				return _notifyUI;
			}
			set
			{
				if (_notifyUI == value)
				{
					return;
				}
				_notifyUI = value;
				PropertySet(this);
			}
		}

		public questJournalChangeMappinPhase_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
