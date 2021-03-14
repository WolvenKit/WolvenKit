using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipEvolutionModule : ItemTooltipModuleController
	{
		private inkImageWidgetReference _weaponEvolutionIcon;
		private inkTextWidgetReference _weaponEvolutionName;
		private inkTextWidgetReference _weaponEvolutionDescription;

		[Ordinal(2)] 
		[RED("weaponEvolutionIcon")] 
		public inkImageWidgetReference WeaponEvolutionIcon
		{
			get
			{
				if (_weaponEvolutionIcon == null)
				{
					_weaponEvolutionIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "weaponEvolutionIcon", cr2w, this);
				}
				return _weaponEvolutionIcon;
			}
			set
			{
				if (_weaponEvolutionIcon == value)
				{
					return;
				}
				_weaponEvolutionIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weaponEvolutionName")] 
		public inkTextWidgetReference WeaponEvolutionName
		{
			get
			{
				if (_weaponEvolutionName == null)
				{
					_weaponEvolutionName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponEvolutionName", cr2w, this);
				}
				return _weaponEvolutionName;
			}
			set
			{
				if (_weaponEvolutionName == value)
				{
					return;
				}
				_weaponEvolutionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weaponEvolutionDescription")] 
		public inkTextWidgetReference WeaponEvolutionDescription
		{
			get
			{
				if (_weaponEvolutionDescription == null)
				{
					_weaponEvolutionDescription = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weaponEvolutionDescription", cr2w, this);
				}
				return _weaponEvolutionDescription;
			}
			set
			{
				if (_weaponEvolutionDescription == value)
				{
					return;
				}
				_weaponEvolutionDescription = value;
				PropertySet(this);
			}
		}

		public ItemTooltipEvolutionModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
