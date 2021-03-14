using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QueueCombatExperience : gamePlayerScriptableSystemRequest
	{
		private CFloat _amount;
		private CEnum<gamedataProficiencyType> _experienceType;
		private entEntityID _entity;

		[Ordinal(1)] 
		[RED("amount")] 
		public CFloat Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CFloat) CR2WTypeManager.Create("Float", "amount", cr2w, this);
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
		[RED("entity")] 
		public entEntityID Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (entEntityID) CR2WTypeManager.Create("entEntityID", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		public QueueCombatExperience(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
