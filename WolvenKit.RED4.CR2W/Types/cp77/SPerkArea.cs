using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPerkArea : CVariable
	{
		private CEnum<gamedataPerkArea> _type;
		private CBool _unlocked;
		private CArray<SPerk> _boughtPerks;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gamedataPerkArea> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataPerkArea>) CR2WTypeManager.Create("gamedataPerkArea", "type", cr2w, this);
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
		[RED("boughtPerks")] 
		public CArray<SPerk> BoughtPerks
		{
			get
			{
				if (_boughtPerks == null)
				{
					_boughtPerks = (CArray<SPerk>) CR2WTypeManager.Create("array:SPerk", "boughtPerks", cr2w, this);
				}
				return _boughtPerks;
			}
			set
			{
				if (_boughtPerks == value)
				{
					return;
				}
				_boughtPerks = value;
				PropertySet(this);
			}
		}

		public SPerkArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
