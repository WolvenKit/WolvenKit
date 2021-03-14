using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STrait : CVariable
	{
		private CEnum<gamedataTraitType> _type;
		private CBool _unlocked;
		private CInt32 _currLevel;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataTraitType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataTraitType>) CR2WTypeManager.Create("gamedataTraitType", "type", cr2w, this);
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

		[Ordinal(1)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get
			{
				if (_unlocked == null)
				{
					_unlocked = (CBool) CR2WTypeManager.Create("Bool", "unlocked", cr2w, this);
				}
				return _unlocked;
			}
			set
			{
				if (_unlocked == value)
				{
					return;
				}
				_unlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currLevel")] 
		public CInt32 CurrLevel
		{
			get
			{
				if (_currLevel == null)
				{
					_currLevel = (CInt32) CR2WTypeManager.Create("Int32", "currLevel", cr2w, this);
				}
				return _currLevel;
			}
			set
			{
				if (_currLevel == value)
				{
					return;
				}
				_currLevel = value;
				PropertySet(this);
			}
		}

		public STrait(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
