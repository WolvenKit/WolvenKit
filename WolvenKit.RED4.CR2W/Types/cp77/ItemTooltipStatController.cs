using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statName;
		private inkTextWidgetReference _statValue;
		private inkWidgetReference _statComparedContainer;
		private inkTextWidgetReference _statComparedValue;
		private inkImageWidgetReference _arrow;

		[Ordinal(1)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get
			{
				if (_statName == null)
				{
					_statName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statName", cr2w, this);
				}
				return _statName;
			}
			set
			{
				if (_statName == value)
				{
					return;
				}
				_statName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get
			{
				if (_statValue == null)
				{
					_statValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statValue", cr2w, this);
				}
				return _statValue;
			}
			set
			{
				if (_statValue == value)
				{
					return;
				}
				_statValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statComparedContainer")] 
		public inkWidgetReference StatComparedContainer
		{
			get
			{
				if (_statComparedContainer == null)
				{
					_statComparedContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statComparedContainer", cr2w, this);
				}
				return _statComparedContainer;
			}
			set
			{
				if (_statComparedContainer == value)
				{
					return;
				}
				_statComparedContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statComparedValue")] 
		public inkTextWidgetReference StatComparedValue
		{
			get
			{
				if (_statComparedValue == null)
				{
					_statComparedValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statComparedValue", cr2w, this);
				}
				return _statComparedValue;
			}
			set
			{
				if (_statComparedValue == value)
				{
					return;
				}
				_statComparedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		public ItemTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
