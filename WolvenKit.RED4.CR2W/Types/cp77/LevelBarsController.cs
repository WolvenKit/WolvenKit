using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelBarsController : inkWidgetLogicController
	{
		private inkWidgetReference _bar0;
		private inkWidgetReference _bar1;
		private inkWidgetReference _bar2;
		private inkWidgetReference _bar3;
		private inkWidgetReference _bar4;
		private CArrayFixedSize<inkWidgetReference> _bars;

		[Ordinal(1)] 
		[RED("bar0")] 
		public inkWidgetReference Bar0
		{
			get
			{
				if (_bar0 == null)
				{
					_bar0 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar0", cr2w, this);
				}
				return _bar0;
			}
			set
			{
				if (_bar0 == value)
				{
					return;
				}
				_bar0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bar1")] 
		public inkWidgetReference Bar1
		{
			get
			{
				if (_bar1 == null)
				{
					_bar1 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar1", cr2w, this);
				}
				return _bar1;
			}
			set
			{
				if (_bar1 == value)
				{
					return;
				}
				_bar1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bar2")] 
		public inkWidgetReference Bar2
		{
			get
			{
				if (_bar2 == null)
				{
					_bar2 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar2", cr2w, this);
				}
				return _bar2;
			}
			set
			{
				if (_bar2 == value)
				{
					return;
				}
				_bar2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bar3")] 
		public inkWidgetReference Bar3
		{
			get
			{
				if (_bar3 == null)
				{
					_bar3 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar3", cr2w, this);
				}
				return _bar3;
			}
			set
			{
				if (_bar3 == value)
				{
					return;
				}
				_bar3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("bar4")] 
		public inkWidgetReference Bar4
		{
			get
			{
				if (_bar4 == null)
				{
					_bar4 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar4", cr2w, this);
				}
				return _bar4;
			}
			set
			{
				if (_bar4 == value)
				{
					return;
				}
				_bar4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bars", 5)] 
		public CArrayFixedSize<inkWidgetReference> Bars
		{
			get
			{
				if (_bars == null)
				{
					_bars = (CArrayFixedSize<inkWidgetReference>) CR2WTypeManager.Create("[5]inkWidgetReference", "bars", cr2w, this);
				}
				return _bars;
			}
			set
			{
				if (_bars == value)
				{
					return;
				}
				_bars = value;
				PropertySet(this);
			}
		}

		public LevelBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
