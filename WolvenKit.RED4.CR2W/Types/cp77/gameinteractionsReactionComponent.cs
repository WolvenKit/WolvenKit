using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsReactionComponent : entIComponent
	{
		private CArray<gameinteractionsReactionData> _reactions;
		private CBool _triggerAutomatically;

		[Ordinal(3)] 
		[RED("reactions")] 
		public CArray<gameinteractionsReactionData> Reactions
		{
			get
			{
				if (_reactions == null)
				{
					_reactions = (CArray<gameinteractionsReactionData>) CR2WTypeManager.Create("array:gameinteractionsReactionData", "reactions", cr2w, this);
				}
				return _reactions;
			}
			set
			{
				if (_reactions == value)
				{
					return;
				}
				_reactions = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("triggerAutomatically")] 
		public CBool TriggerAutomatically
		{
			get
			{
				if (_triggerAutomatically == null)
				{
					_triggerAutomatically = (CBool) CR2WTypeManager.Create("Bool", "triggerAutomatically", cr2w, this);
				}
				return _triggerAutomatically;
			}
			set
			{
				if (_triggerAutomatically == value)
				{
					return;
				}
				_triggerAutomatically = value;
				PropertySet(this);
			}
		}

		public gameinteractionsReactionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
