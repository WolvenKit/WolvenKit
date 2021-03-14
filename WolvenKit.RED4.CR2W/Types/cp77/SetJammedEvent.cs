using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetJammedEvent : redEvent
	{
		private CBool _newJammedState;
		private wCHandle<gameweaponObject> _instigator;

		[Ordinal(0)] 
		[RED("newJammedState")] 
		public CBool NewJammedState
		{
			get
			{
				if (_newJammedState == null)
				{
					_newJammedState = (CBool) CR2WTypeManager.Create("Bool", "newJammedState", cr2w, this);
				}
				return _newJammedState;
			}
			set
			{
				if (_newJammedState == value)
				{
					return;
				}
				_newJammedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameweaponObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameweaponObject>) CR2WTypeManager.Create("whandle:gameweaponObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		public SetJammedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
