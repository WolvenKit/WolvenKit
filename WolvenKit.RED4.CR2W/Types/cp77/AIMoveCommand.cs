using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveCommand : AICommand
	{
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(4)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get
			{
				if (_removeAfterCombat == null)
				{
					_removeAfterCombat = (CBool) CR2WTypeManager.Create("Bool", "removeAfterCombat", cr2w, this);
				}
				return _removeAfterCombat;
			}
			set
			{
				if (_removeAfterCombat == value)
				{
					return;
				}
				_removeAfterCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get
			{
				if (_ignoreInCombat == null)
				{
					_ignoreInCombat = (CBool) CR2WTypeManager.Create("Bool", "ignoreInCombat", cr2w, this);
				}
				return _ignoreInCombat;
			}
			set
			{
				if (_ignoreInCombat == value)
				{
					return;
				}
				_ignoreInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get
			{
				if (_alwaysUseStealth == null)
				{
					_alwaysUseStealth = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseStealth", cr2w, this);
				}
				return _alwaysUseStealth;
			}
			set
			{
				if (_alwaysUseStealth == value)
				{
					return;
				}
				_alwaysUseStealth = value;
				PropertySet(this);
			}
		}

		public AIMoveCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
