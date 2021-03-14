using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddExperience : gamePlayerScriptableSystemRequest
	{
		private CInt32 _amount;
		private CEnum<gamedataProficiencyType> _experienceType;
		private CBool _debug;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("experienceType")] 
		public CEnum<gamedataProficiencyType> ExperienceType
		{
			get
			{
				if (_experienceType == null)
				{
					_experienceType = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "experienceType", cr2w, this);
				}
				return _experienceType;
			}
			set
			{
				if (_experienceType == value)
				{
					return;
				}
				_experienceType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		public AddExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
