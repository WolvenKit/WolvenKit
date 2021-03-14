using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SExperiencePoints : CVariable
	{
		private CFloat _amount;
		private CEnum<gamedataProficiencyType> _forType;
		private entEntityID _entity;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("forType")] 
		public CEnum<gamedataProficiencyType> ForType
		{
			get
			{
				if (_forType == null)
				{
					_forType = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "forType", cr2w, this);
				}
				return _forType;
			}
			set
			{
				if (_forType == value)
				{
					return;
				}
				_forType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public SExperiencePoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
