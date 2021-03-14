using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableTransform : animAnimVariable
	{
		private QsTransform _value;
		private QsTransform _default;

		[Ordinal(2)] 
		[RED("value")] 
		public QsTransform Value
		{
			get
			{
				if (_value == null)
				{
					_value = (QsTransform) CR2WTypeManager.Create("QsTransform", "value", cr2w, this);
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
		public QsTransform Default
		{
			get
			{
				if (_default == null)
				{
					_default = (QsTransform) CR2WTypeManager.Create("QsTransform", "default", cr2w, this);
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

		public animAnimVariableTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
