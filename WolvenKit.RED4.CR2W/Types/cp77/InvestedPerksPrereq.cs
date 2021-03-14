using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InvestedPerksPrereq : gameIScriptablePrereq
	{
		private CInt32 _amount;
		private CEnum<gamedataProficiencyType> _proficiency;

		[Ordinal(0)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get
			{
				if (_proficiency == null)
				{
					_proficiency = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiency", cr2w, this);
				}
				return _proficiency;
			}
			set
			{
				if (_proficiency == value)
				{
					return;
				}
				_proficiency = value;
				PropertySet(this);
			}
		}

		public InvestedPerksPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
