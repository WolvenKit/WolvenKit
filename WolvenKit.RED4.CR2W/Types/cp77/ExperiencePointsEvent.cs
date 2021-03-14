using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExperiencePointsEvent : redEvent
	{
		private CInt32 _amount;
		private CEnum<gamedataProficiencyType> _type;
		private CBool _isDebug;

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
		[RED("isDebug")] 
		public CBool IsDebug
		{
			get
			{
				if (_isDebug == null)
				{
					_isDebug = (CBool) CR2WTypeManager.Create("Bool", "isDebug", cr2w, this);
				}
				return _isDebug;
			}
			set
			{
				if (_isDebug == value)
				{
					return;
				}
				_isDebug = value;
				PropertySet(this);
			}
		}

		public ExperiencePointsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
