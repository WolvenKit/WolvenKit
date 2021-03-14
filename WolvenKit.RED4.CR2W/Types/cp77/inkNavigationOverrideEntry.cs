using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkNavigationOverrideEntry : CVariable
	{
		private inkWidgetReference _from;
		private CEnum<inkDiscreteNavigationDirection> _direction;
		private inkWidgetReference _to;

		[Ordinal(0)] 
		[RED("from")] 
		public inkWidgetReference From
		{
			get
			{
				if (_from == null)
				{
					_from = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<inkDiscreteNavigationDirection> Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (CEnum<inkDiscreteNavigationDirection>) CR2WTypeManager.Create("inkDiscreteNavigationDirection", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("to")] 
		public inkWidgetReference To
		{
			get
			{
				if (_to == null)
				{
					_to = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "to", cr2w, this);
				}
				return _to;
			}
			set
			{
				if (_to == value)
				{
					return;
				}
				_to = value;
				PropertySet(this);
			}
		}

		public inkNavigationOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
