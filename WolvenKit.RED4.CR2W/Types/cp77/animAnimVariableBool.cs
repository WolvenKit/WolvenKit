using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableBool : animAnimVariable
	{
		private CBool _value;
		private CBool _default;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("default")] 
		public CBool Default
		{
			get
			{
				if (_default == null)
				{
					_default = (CBool) CR2WTypeManager.Create("Bool", "default", cr2w, this);
				}
				return _default;
			}
			set
			{
				if (_default == value)
				{
					return;
				}
				_default = value;
				PropertySet(this);
			}
		}

		public animAnimVariableBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
