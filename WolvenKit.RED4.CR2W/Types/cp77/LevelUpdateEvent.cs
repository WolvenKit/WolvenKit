using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpdateEvent : redEvent
	{
		private CInt32 _lvl;
		private CEnum<gamedataProficiencyType> _type;
		private CArray<SDevelopmentPoints> _devPoints;

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
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get
			{
				if (_devPoints == null)
				{
					_devPoints = (CArray<SDevelopmentPoints>) CR2WTypeManager.Create("array:SDevelopmentPoints", "devPoints", cr2w, this);
				}
				return _devPoints;
			}
			set
			{
				if (_devPoints == value)
				{
					return;
				}
				_devPoints = value;
				PropertySet(this);
			}
		}

		public LevelUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
