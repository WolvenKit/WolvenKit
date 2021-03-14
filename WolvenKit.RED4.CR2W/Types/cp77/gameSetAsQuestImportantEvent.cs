using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetAsQuestImportantEvent : redEvent
	{
		private CBool _isImportant;
		private CBool _propagateToSlaves;

		[Ordinal(0)] 
		[RED("isImportant")] 
		public CBool IsImportant
		{
			get
			{
				if (_isImportant == null)
				{
					_isImportant = (CBool) CR2WTypeManager.Create("Bool", "isImportant", cr2w, this);
				}
				return _isImportant;
			}
			set
			{
				if (_isImportant == value)
				{
					return;
				}
				_isImportant = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propagateToSlaves")] 
		public CBool PropagateToSlaves
		{
			get
			{
				if (_propagateToSlaves == null)
				{
					_propagateToSlaves = (CBool) CR2WTypeManager.Create("Bool", "propagateToSlaves", cr2w, this);
				}
				return _propagateToSlaves;
			}
			set
			{
				if (_propagateToSlaves == value)
				{
					return;
				}
				_propagateToSlaves = value;
				PropertySet(this);
			}
		}

		public gameSetAsQuestImportantEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
