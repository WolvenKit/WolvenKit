using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopStringUint64Pair : CVariable
	{
		private CString _string;
		private CUInt64 _number;

		[Ordinal(0)] 
		[RED("string")] 
		public CString String
		{
			get
			{
				if (_string == null)
				{
					_string = (CString) CR2WTypeManager.Create("String", "string", cr2w, this);
				}
				return _string;
			}
			set
			{
				if (_string == value)
				{
					return;
				}
				_string = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("number")] 
		public CUInt64 Number
		{
			get
			{
				if (_number == null)
				{
					_number = (CUInt64) CR2WTypeManager.Create("Uint64", "number", cr2w, this);
				}
				return _number;
			}
			set
			{
				if (_number == value)
				{
					return;
				}
				_number = value;
				PropertySet(this);
			}
		}

		public interopStringUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
