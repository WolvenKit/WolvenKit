using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldConversationGroupData : ISerializable
	{
		private rRef<scnInterestingConversationsResource> _conversationGroup;
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;
		private CBool _ignoreLocalLimit;
		private CBool _ignoreGlobalLimit;

		[Ordinal(0)] 
		[RED("conversationGroup")] 
		public rRef<scnInterestingConversationsResource> ConversationGroup
		{
			get
			{
				if (_conversationGroup == null)
				{
					_conversationGroup = (rRef<scnInterestingConversationsResource>) CR2WTypeManager.Create("rRef:scnInterestingConversationsResource", "conversationGroup", cr2w, this);
				}
				return _conversationGroup;
			}
			set
			{
				if (_conversationGroup == value)
				{
					return;
				}
				_conversationGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get
			{
				if (_interruptionOperations == null)
				{
					_interruptionOperations = (CArray<CHandle<scnIInterruptionOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionOperation", "interruptionOperations", cr2w, this);
				}
				return _interruptionOperations;
			}
			set
			{
				if (_interruptionOperations == value)
				{
					return;
				}
				_interruptionOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreLocalLimit")] 
		public CBool IgnoreLocalLimit
		{
			get
			{
				if (_ignoreLocalLimit == null)
				{
					_ignoreLocalLimit = (CBool) CR2WTypeManager.Create("Bool", "ignoreLocalLimit", cr2w, this);
				}
				return _ignoreLocalLimit;
			}
			set
			{
				if (_ignoreLocalLimit == value)
				{
					return;
				}
				_ignoreLocalLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ignoreGlobalLimit")] 
		public CBool IgnoreGlobalLimit
		{
			get
			{
				if (_ignoreGlobalLimit == null)
				{
					_ignoreGlobalLimit = (CBool) CR2WTypeManager.Create("Bool", "ignoreGlobalLimit", cr2w, this);
				}
				return _ignoreGlobalLimit;
			}
			set
			{
				if (_ignoreGlobalLimit == value)
				{
					return;
				}
				_ignoreGlobalLimit = value;
				PropertySet(this);
			}
		}

		public worldConversationGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
