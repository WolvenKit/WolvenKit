using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipDetailsModule : ItemTooltipModuleController
	{
		private inkWidgetReference _statsLine;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkWidgetReference _dedicatedModsLine;
		private inkWidgetReference _dedicatedModsWrapper;
		private inkCompoundWidgetReference _dedicatedModsContainer;
		private inkWidgetReference _modsLine;
		private inkWidgetReference _modsWrapper;
		private inkCompoundWidgetReference _modsContainer;

		[Ordinal(2)] 
		[RED("statsLine")] 
		public inkWidgetReference StatsLine
		{
			get
			{
				if (_statsLine == null)
				{
					_statsLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsLine", cr2w, this);
				}
				return _statsLine;
			}
			set
			{
				if (_statsLine == value)
				{
					return;
				}
				_statsLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get
			{
				if (_statsWrapper == null)
				{
					_statsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsWrapper", cr2w, this);
				}
				return _statsWrapper;
			}
			set
			{
				if (_statsWrapper == value)
				{
					return;
				}
				_statsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get
			{
				if (_statsContainer == null)
				{
					_statsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "statsContainer", cr2w, this);
				}
				return _statsContainer;
			}
			set
			{
				if (_statsContainer == value)
				{
					return;
				}
				_statsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dedicatedModsLine")] 
		public inkWidgetReference DedicatedModsLine
		{
			get
			{
				if (_dedicatedModsLine == null)
				{
					_dedicatedModsLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dedicatedModsLine", cr2w, this);
				}
				return _dedicatedModsLine;
			}
			set
			{
				if (_dedicatedModsLine == value)
				{
					return;
				}
				_dedicatedModsLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dedicatedModsWrapper")] 
		public inkWidgetReference DedicatedModsWrapper
		{
			get
			{
				if (_dedicatedModsWrapper == null)
				{
					_dedicatedModsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dedicatedModsWrapper", cr2w, this);
				}
				return _dedicatedModsWrapper;
			}
			set
			{
				if (_dedicatedModsWrapper == value)
				{
					return;
				}
				_dedicatedModsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dedicatedModsContainer")] 
		public inkCompoundWidgetReference DedicatedModsContainer
		{
			get
			{
				if (_dedicatedModsContainer == null)
				{
					_dedicatedModsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "dedicatedModsContainer", cr2w, this);
				}
				return _dedicatedModsContainer;
			}
			set
			{
				if (_dedicatedModsContainer == value)
				{
					return;
				}
				_dedicatedModsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("modsLine")] 
		public inkWidgetReference ModsLine
		{
			get
			{
				if (_modsLine == null)
				{
					_modsLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "modsLine", cr2w, this);
				}
				return _modsLine;
			}
			set
			{
				if (_modsLine == value)
				{
					return;
				}
				_modsLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("modsWrapper")] 
		public inkWidgetReference ModsWrapper
		{
			get
			{
				if (_modsWrapper == null)
				{
					_modsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "modsWrapper", cr2w, this);
				}
				return _modsWrapper;
			}
			set
			{
				if (_modsWrapper == value)
				{
					return;
				}
				_modsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("modsContainer")] 
		public inkCompoundWidgetReference ModsContainer
		{
			get
			{
				if (_modsContainer == null)
				{
					_modsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "modsContainer", cr2w, this);
				}
				return _modsContainer;
			}
			set
			{
				if (_modsContainer == value)
				{
					return;
				}
				_modsContainer = value;
				PropertySet(this);
			}
		}

		public ItemTooltipDetailsModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
