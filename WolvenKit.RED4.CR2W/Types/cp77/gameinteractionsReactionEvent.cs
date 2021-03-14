using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionEvent : redEvent
	{
		private CName _interactionType;
		private CArray<gameEquipParam> _interactionItems;
		private CEnum<gameinteractionsReactionState> _state;

		[Ordinal(0)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get
			{
				if (_interactionType == null)
				{
					_interactionType = (CName) CR2WTypeManager.Create("CName", "interactionType", cr2w, this);
				}
				return _interactionType;
			}
			set
			{
				if (_interactionType == value)
				{
					return;
				}
				_interactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interactionItems")] 
		public CArray<gameEquipParam> InteractionItems
		{
			get
			{
				if (_interactionItems == null)
				{
					_interactionItems = (CArray<gameEquipParam>) CR2WTypeManager.Create("array:gameEquipParam", "interactionItems", cr2w, this);
				}
				return _interactionItems;
			}
			set
			{
				if (_interactionItems == value)
				{
					return;
				}
				_interactionItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameinteractionsReactionState>) CR2WTypeManager.Create("gameinteractionsReactionState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public gameinteractionsReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
