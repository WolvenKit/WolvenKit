using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsHitCharacterControllerEvent : redEvent
	{
		private wCHandle<entEntity> _entity;
		private wCHandle<entIComponent> _component;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("component")] 
		public wCHandle<entIComponent> Component
		{
			get
			{
				if (_component == null)
				{
					_component = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "component", cr2w, this);
				}
				return _component;
			}
			set
			{
				if (_component == value)
				{
					return;
				}
				_component = value;
				PropertySet(this);
			}
		}

		public enteventsHitCharacterControllerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
