using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IllegalActionTypes : CVariable
	{
		private CBool _regularActions;
		private CBool _quickHacks;
		private CBool _skillChecks;

		[Ordinal(0)] 
		[RED("regularActions")] 
		public CBool RegularActions
		{
			get
			{
				if (_regularActions == null)
				{
					_regularActions = (CBool) CR2WTypeManager.Create("Bool", "regularActions", cr2w, this);
				}
				return _regularActions;
			}
			set
			{
				if (_regularActions == value)
				{
					return;
				}
				_regularActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("quickHacks")] 
		public CBool QuickHacks
		{
			get
			{
				if (_quickHacks == null)
				{
					_quickHacks = (CBool) CR2WTypeManager.Create("Bool", "quickHacks", cr2w, this);
				}
				return _quickHacks;
			}
			set
			{
				if (_quickHacks == value)
				{
					return;
				}
				_quickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skillChecks")] 
		public CBool SkillChecks
		{
			get
			{
				if (_skillChecks == null)
				{
					_skillChecks = (CBool) CR2WTypeManager.Create("Bool", "skillChecks", cr2w, this);
				}
				return _skillChecks;
			}
			set
			{
				if (_skillChecks == value)
				{
					return;
				}
				_skillChecks = value;
				PropertySet(this);
			}
		}

		public IllegalActionTypes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
