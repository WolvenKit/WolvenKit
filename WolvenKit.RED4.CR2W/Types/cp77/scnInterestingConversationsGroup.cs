using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterestingConversationsGroup : ISerializable
	{
		private CHandle<questIBaseCondition> _condition;
		private CArray<CHandle<scnInterestingConversationData>> _conversations;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("conversations")] 
		public CArray<CHandle<scnInterestingConversationData>> Conversations
		{
			get
			{
				if (_conversations == null)
				{
					_conversations = (CArray<CHandle<scnInterestingConversationData>>) CR2WTypeManager.Create("array:handle:scnInterestingConversationData", "conversations", cr2w, this);
				}
				return _conversations;
			}
			set
			{
				if (_conversations == value)
				{
					return;
				}
				_conversations = value;
				PropertySet(this);
			}
		}

		public scnInterestingConversationsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
