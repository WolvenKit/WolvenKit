using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapDistrictTooltipController : WorldMapTooltipBaseController
	{
		private inkTextWidgetReference _titleText;
		private inkTextWidgetReference _levelRangeText;
		private inkTextWidgetReference _threatText;
		private inkTextWidgetReference _completionText;
		private inkWidgetReference _gangsContainer;
		private inkCompoundWidgetReference _gangsList;
		private CArray<wCHandle<WorldMapGangItemController>> _gangControllers;

		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get
			{
				if (_titleText == null)
				{
					_titleText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "titleText", cr2w, this);
				}
				return _titleText;
			}
			set
			{
				if (_titleText == value)
				{
					return;
				}
				_titleText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("levelRangeText")] 
		public inkTextWidgetReference LevelRangeText
		{
			get
			{
				if (_levelRangeText == null)
				{
					_levelRangeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelRangeText", cr2w, this);
				}
				return _levelRangeText;
			}
			set
			{
				if (_levelRangeText == value)
				{
					return;
				}
				_levelRangeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("threatText")] 
		public inkTextWidgetReference ThreatText
		{
			get
			{
				if (_threatText == null)
				{
					_threatText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "threatText", cr2w, this);
				}
				return _threatText;
			}
			set
			{
				if (_threatText == value)
				{
					return;
				}
				_threatText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("completionText")] 
		public inkTextWidgetReference CompletionText
		{
			get
			{
				if (_completionText == null)
				{
					_completionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "completionText", cr2w, this);
				}
				return _completionText;
			}
			set
			{
				if (_completionText == value)
				{
					return;
				}
				_completionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gangsContainer")] 
		public inkWidgetReference GangsContainer
		{
			get
			{
				if (_gangsContainer == null)
				{
					_gangsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gangsContainer", cr2w, this);
				}
				return _gangsContainer;
			}
			set
			{
				if (_gangsContainer == value)
				{
					return;
				}
				_gangsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("gangsList")] 
		public inkCompoundWidgetReference GangsList
		{
			get
			{
				if (_gangsList == null)
				{
					_gangsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "gangsList", cr2w, this);
				}
				return _gangsList;
			}
			set
			{
				if (_gangsList == value)
				{
					return;
				}
				_gangsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("gangControllers")] 
		public CArray<wCHandle<WorldMapGangItemController>> GangControllers
		{
			get
			{
				if (_gangControllers == null)
				{
					_gangControllers = (CArray<wCHandle<WorldMapGangItemController>>) CR2WTypeManager.Create("array:whandle:WorldMapGangItemController", "gangControllers", cr2w, this);
				}
				return _gangControllers;
			}
			set
			{
				if (_gangControllers == value)
				{
					return;
				}
				_gangControllers = value;
				PropertySet(this);
			}
		}

		public WorldMapDistrictTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
