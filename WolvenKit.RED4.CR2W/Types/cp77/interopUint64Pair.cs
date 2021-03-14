using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopUint64Pair : CVariable
	{
		private CUInt64 _first;
		private CUInt64 _second;

		[Ordinal(0)] 
		[RED("first")] 
		public CUInt64 First
		{
			get
			{
				if (_first == null)
				{
					_first = (CUInt64) CR2WTypeManager.Create("Uint64", "first", cr2w, this);
				}
				return _first;
			}
			set
			{
				if (_first == value)
				{
					return;
				}
				_first = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("second")] 
		public CUInt64 Second
		{
			get
			{
				if (_second == null)
				{
					_second = (CUInt64) CR2WTypeManager.Create("Uint64", "second", cr2w, this);
				}
				return _second;
			}
			set
			{
				if (_second == value)
				{
					return;
				}
				_second = value;
				PropertySet(this);
			}
		}

		public interopUint64Pair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
