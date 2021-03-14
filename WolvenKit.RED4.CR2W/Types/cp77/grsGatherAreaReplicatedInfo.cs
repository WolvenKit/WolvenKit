using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsGatherAreaReplicatedInfo : CVariable
	{
		private CStatic<netPeerID> _enteredPlayerIDs;
		private CBool _hasActiveQuestListener;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("enteredPlayerIDs", 7)] 
		public CStatic<netPeerID> EnteredPlayerIDs
		{
			get
			{
				if (_enteredPlayerIDs == null)
				{
					_enteredPlayerIDs = (CStatic<netPeerID>) CR2WTypeManager.Create("static:7,netPeerID", "enteredPlayerIDs", cr2w, this);
				}
				return _enteredPlayerIDs;
			}
			set
			{
				if (_enteredPlayerIDs == value)
				{
					return;
				}
				_enteredPlayerIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasActiveQuestListener")] 
		public CBool HasActiveQuestListener
		{
			get
			{
				if (_hasActiveQuestListener == null)
				{
					_hasActiveQuestListener = (CBool) CR2WTypeManager.Create("Bool", "hasActiveQuestListener", cr2w, this);
				}
				return _hasActiveQuestListener;
			}
			set
			{
				if (_hasActiveQuestListener == value)
				{
					return;
				}
				_hasActiveQuestListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		public grsGatherAreaReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
