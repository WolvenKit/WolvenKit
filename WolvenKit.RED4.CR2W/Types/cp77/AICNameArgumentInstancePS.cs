using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICNameArgumentInstancePS : AIArgumentInstancePS
	{
		private CName _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CName Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CName) CR2WTypeManager.Create("CName", "value", cr2w, this);
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

		public AICNameArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
