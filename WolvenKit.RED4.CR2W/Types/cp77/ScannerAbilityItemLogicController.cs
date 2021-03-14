using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilityItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _abilityNameText;
		private inkImageWidgetReference _abilityIcon;
		private CHandle<gamedataGameplayAbility_Record> _abilityStruct;

		[Ordinal(1)] 
		[RED("abilityNameText")] 
		public inkTextWidgetReference AbilityNameText
		{
			get
			{
				if (_abilityNameText == null)
				{
					_abilityNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "abilityNameText", cr2w, this);
				}
				return _abilityNameText;
			}
			set
			{
				if (_abilityNameText == value)
				{
					return;
				}
				_abilityNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("abilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get
			{
				if (_abilityIcon == null)
				{
					_abilityIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "abilityIcon", cr2w, this);
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

		[Ordinal(3)] 
		[RED("abilityStruct")] 
		public CHandle<gamedataGameplayAbility_Record> AbilityStruct
		{
			get
			{
				if (_abilityStruct == null)
				{
					_abilityStruct = (CHandle<gamedataGameplayAbility_Record>) CR2WTypeManager.Create("handle:gamedataGameplayAbility_Record", "abilityStruct", cr2w, this);
				}
				return _abilityStruct;
			}
			set
			{
				if (_abilityStruct == value)
				{
					return;
				}
				_abilityStruct = value;
				PropertySet(this);
			}
		}

		public ScannerAbilityItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
