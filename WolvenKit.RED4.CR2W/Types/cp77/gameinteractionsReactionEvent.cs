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
			get => GetProperty(ref _interactionType);
			set => SetProperty(ref _interactionType, value);
		}

		[Ordinal(1)] 
		[RED("interactionItems")] 
		public CArray<gameEquipParam> InteractionItems
		{
			get => GetProperty(ref _interactionItems);
			set => SetProperty(ref _interactionItems, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public gameinteractionsReactionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
