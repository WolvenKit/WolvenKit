using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIObjectId : CVariable
	{
		private CUInt64 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CUInt64) CR2WTypeManager.Create("Uint64", "value", cr2w, this);
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

		public AIObjectId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
