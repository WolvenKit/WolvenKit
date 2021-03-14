using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLevelUpData : CVariable
	{
		private CInt32 _lvl;
		private CEnum<gamedataProficiencyType> _type;
		private CInt32 _perkPoints;
		private CInt32 _attributePoints;
		private CBool _disableAction;

		[Ordinal(0)] 
		[RED("lvl")] 
		public CInt32 Lvl
		{
			get
			{
				if (_lvl == null)
				{
					_lvl = (CInt32) CR2WTypeManager.Create("Int32", "lvl", cr2w, this);
				}
				return _lvl;
			}
			set
			{
				if (_lvl == value)
				{
					return;
				}
				_lvl = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("perkPoints")] 
		public CInt32 PerkPoints
		{
			get
			{
				if (_perkPoints == null)
				{
					_perkPoints = (CInt32) CR2WTypeManager.Create("Int32", "perkPoints", cr2w, this);
				}
				return _perkPoints;
			}
			set
			{
				if (_perkPoints == value)
				{
					return;
				}
				_perkPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attributePoints")] 
		public CInt32 AttributePoints
		{
			get
			{
				if (_attributePoints == null)
				{
					_attributePoints = (CInt32) CR2WTypeManager.Create("Int32", "attributePoints", cr2w, this);
				}
				return _attributePoints;
			}
			set
			{
				if (_attributePoints == value)
				{
					return;
				}
				_attributePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("disableAction")] 
		public CBool DisableAction
		{
			get
			{
				if (_disableAction == null)
				{
					_disableAction = (CBool) CR2WTypeManager.Create("Bool", "disableAction", cr2w, this);
				}
				return _disableAction;
			}
			set
			{
				if (_disableAction == value)
				{
					return;
				}
				_disableAction = value;
				PropertySet(this);
			}
		}

		public questLevelUpData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
