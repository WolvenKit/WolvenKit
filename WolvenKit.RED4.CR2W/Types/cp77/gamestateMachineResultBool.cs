using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineResultBool : CVariable
	{
		private CBool _value;
		private CBool _valid;

		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CBool) CR2WTypeManager.Create("Bool", "value", cr2w, this);
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

		[Ordinal(1)] 
		[RED("valid")] 
		public CBool Valid
		{
			get
			{
				if (_valid == null)
				{
					_valid = (CBool) CR2WTypeManager.Create("Bool", "valid", cr2w, this);
				}
				return _valid;
			}
			set
			{
				if (_valid == value)
				{
					return;
				}
				_valid = value;
				PropertySet(this);
			}
		}

		public gamestateMachineResultBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
