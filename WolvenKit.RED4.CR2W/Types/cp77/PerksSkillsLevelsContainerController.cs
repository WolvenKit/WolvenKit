using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelsContainerController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _topRowItemsContainer;
		private inkCompoundWidgetReference _bottomRowItemsContainer;
		private inkWidgetReference _levelBar;
		private inkWidgetReference _levelBarSpacer;
		private inkTextWidgetReference _label;
		private CHandle<ProficiencyDisplayData> _proficiencyDisplayData;

		[Ordinal(1)] 
		[RED("topRowItemsContainer")] 
		public inkCompoundWidgetReference TopRowItemsContainer
		{
			get
			{
				if (_topRowItemsContainer == null)
				{
					_topRowItemsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "topRowItemsContainer", cr2w, this);
				}
				return _topRowItemsContainer;
			}
			set
			{
				if (_topRowItemsContainer == value)
				{
					return;
				}
				_topRowItemsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bottomRowItemsContainer")] 
		public inkCompoundWidgetReference BottomRowItemsContainer
		{
			get
			{
				if (_bottomRowItemsContainer == null)
				{
					_bottomRowItemsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "bottomRowItemsContainer", cr2w, this);
				}
				return _bottomRowItemsContainer;
			}
			set
			{
				if (_bottomRowItemsContainer == value)
				{
					return;
				}
				_bottomRowItemsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("levelBar")] 
		public inkWidgetReference LevelBar
		{
			get
			{
				if (_levelBar == null)
				{
					_levelBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBar", cr2w, this);
				}
				return _levelBar;
			}
			set
			{
				if (_levelBar == value)
				{
					return;
				}
				_levelBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get
			{
				if (_levelBarSpacer == null)
				{
					_levelBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBarSpacer", cr2w, this);
				}
				return _levelBarSpacer;
			}
			set
			{
				if (_levelBarSpacer == value)
				{
					return;
				}
				_levelBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("proficiencyDisplayData")] 
		public CHandle<ProficiencyDisplayData> ProficiencyDisplayData
		{
			get
			{
				if (_proficiencyDisplayData == null)
				{
					_proficiencyDisplayData = (CHandle<ProficiencyDisplayData>) CR2WTypeManager.Create("handle:ProficiencyDisplayData", "proficiencyDisplayData", cr2w, this);
				}
				return _proficiencyDisplayData;
			}
			set
			{
				if (_proficiencyDisplayData == value)
				{
					return;
				}
				_proficiencyDisplayData = value;
				PropertySet(this);
			}
		}

		public PerksSkillsLevelsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
