using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipRecipeDataModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _statsLabel;
		private inkWidgetReference _statsWrapper;
		private inkCompoundWidgetReference _statsContainer;
		private inkTextWidgetReference _damageTypesLabel;
		private inkWidgetReference _damageTypesWrapper;
		private inkCompoundWidgetReference _damageTypesContainer;

		[Ordinal(2)] 
		[RED("statsLabel")] 
		public inkTextWidgetReference StatsLabel
		{
			get
			{
				if (_statsLabel == null)
				{
					_statsLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "statsLabel", cr2w, this);
				}
				return _statsLabel;
			}
			set
			{
				if (_statsLabel == value)
				{
					return;
				}
				_statsLabel = value;
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
		[RED("damageTypesLabel")] 
		public inkTextWidgetReference DamageTypesLabel
		{
			get
			{
				if (_damageTypesLabel == null)
				{
					_damageTypesLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damageTypesLabel", cr2w, this);
				}
				return _damageTypesLabel;
			}
			set
			{
				if (_damageTypesLabel == value)
				{
					return;
				}
				_damageTypesLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("damageTypesWrapper")] 
		public inkWidgetReference DamageTypesWrapper
		{
			get
			{
				if (_damageTypesWrapper == null)
				{
					_damageTypesWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageTypesWrapper", cr2w, this);
				}
				return _damageTypesWrapper;
			}
			set
			{
				if (_damageTypesWrapper == value)
				{
					return;
				}
				_damageTypesWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("damageTypesContainer")] 
		public inkCompoundWidgetReference DamageTypesContainer
		{
			get
			{
				if (_damageTypesContainer == null)
				{
					_damageTypesContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "damageTypesContainer", cr2w, this);
				}
				return _damageTypesContainer;
			}
			set
			{
				if (_damageTypesContainer == value)
				{
					return;
				}
				_damageTypesContainer = value;
				PropertySet(this);
			}
		}

		public ItemTooltipRecipeDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
