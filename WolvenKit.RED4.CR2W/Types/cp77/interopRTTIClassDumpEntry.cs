using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopRTTIClassDumpEntry : CVariable
	{
		private CInt32 _i;
		private CInt32 _b;
		private CInt32 _r;
		private CInt32 _a;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get
			{
				if (_i == null)
				{
					_i = (CInt32) CR2WTypeManager.Create("Int32", "i", cr2w, this);
				}
				return _i;
			}
			set
			{
				if (_i == value)
				{
					return;
				}
				_i = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CInt32 B
		{
			get
			{
				if (_b == null)
				{
					_b = (CInt32) CR2WTypeManager.Create("Int32", "b", cr2w, this);
				}
				return _b;
			}
			set
			{
				if (_b == value)
				{
					return;
				}
				_b = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("r")] 
		public CInt32 R
		{
			get
			{
				if (_r == null)
				{
					_r = (CInt32) CR2WTypeManager.Create("Int32", "r", cr2w, this);
				}
				return _r;
			}
			set
			{
				if (_r == value)
				{
					return;
				}
				_r = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("a")] 
		public CInt32 A
		{
			get
			{
				if (_a == null)
				{
					_a = (CInt32) CR2WTypeManager.Create("Int32", "a", cr2w, this);
				}
				return _a;
			}
			set
			{
				if (_a == value)
				{
					return;
				}
				_a = value;
				PropertySet(this);
			}
		}

		public interopRTTIClassDumpEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
