using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInt64ArgumentInstancePS : AIArgumentInstancePS
	{
		private CInt64 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CInt64 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt64) CR2WTypeManager.Create("Int64", "value", cr2w, this);
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

		public AIInt64ArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
