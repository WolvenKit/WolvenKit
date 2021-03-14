using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		private inkImageWidgetReference _abilityIcon;
		private inkTextWidgetReference _abilityDescription;
		private inkWidgetReference _qualityRoot;

		[Ordinal(1)] 
		[RED("AbilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get
			{
				if (_abilityIcon == null)
				{
					_abilityIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "AbilityIcon", cr2w, this);
				}
				return _abilityIcon;
			}
			set
			{
				if (_abilityIcon == value)
				{
					return;
				}
				_abilityIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("AbilityDescription")] 
		public inkTextWidgetReference AbilityDescription
		{
			get
			{
				if (_abilityDescription == null)
				{
					_abilityDescription = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "AbilityDescription", cr2w, this);
				}
				return _abilityDescription;
			}
			set
			{
				if (_abilityDescription == value)
				{
					return;
				}
				_abilityDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("QualityRoot")] 
		public inkWidgetReference QualityRoot
		{
			get
			{
				if (_qualityRoot == null)
				{
					_qualityRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QualityRoot", cr2w, this);
				}
				return _qualityRoot;
			}
			set
			{
				if (_qualityRoot == value)
				{
					return;
				}
				_qualityRoot = value;
				PropertySet(this);
			}
		}

		public TooltipSpecialAbilityDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
