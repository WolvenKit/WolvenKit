using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RestoreStatPoolEffector : gameEffector
	{
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _valueToRestore;
		private CBool _percentage;

		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get
			{
				if (_statPoolType == null)
				{
					_statPoolType = (CEnum<gamedataStatPoolType>) CR2WTypeManager.Create("gamedataStatPoolType", "statPoolType", cr2w, this);
				}
				return _statPoolType;
			}
			set
			{
				if (_statPoolType == value)
				{
					return;
				}
				_statPoolType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("valueToRestore")] 
		public CFloat ValueToRestore
		{
			get
			{
				if (_valueToRestore == null)
				{
					_valueToRestore = (CFloat) CR2WTypeManager.Create("Float", "valueToRestore", cr2w, this);
				}
				return _valueToRestore;
			}
			set
			{
				if (_valueToRestore == value)
				{
					return;
				}
				_valueToRestore = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("percentage")] 
		public CBool Percentage
		{
			get
			{
				if (_percentage == null)
				{
					_percentage = (CBool) CR2WTypeManager.Create("Bool", "percentage", cr2w, this);
				}
				return _percentage;
			}
			set
			{
				if (_percentage == value)
				{
					return;
				}
				_percentage = value;
				PropertySet(this);
			}
		}

		public RestoreStatPoolEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
