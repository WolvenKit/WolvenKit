using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamageEffector : ModifyAttackEffector
	{
		private CEnum<EMathOperator> _operationType;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EMathOperator>) CR2WTypeManager.Create("EMathOperator", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CFloat) CR2WTypeManager.Create("Float", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public ModifyDamageEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
