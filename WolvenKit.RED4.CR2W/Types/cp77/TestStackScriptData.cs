using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestStackScriptData : CVariable
	{
		private CInt32 _testVar;
		private CName _anotherVar;

		[Ordinal(0)] 
		[RED("testVar")] 
		public CInt32 TestVar
		{
			get
			{
				if (_testVar == null)
				{
					_testVar = (CInt32) CR2WTypeManager.Create("Int32", "testVar", cr2w, this);
				}
				return _testVar;
			}
			set
			{
				if (_testVar == value)
				{
					return;
				}
				_testVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("anotherVar")] 
		public CName AnotherVar
		{
			get
			{
				if (_anotherVar == null)
				{
					_anotherVar = (CName) CR2WTypeManager.Create("CName", "anotherVar", cr2w, this);
				}
				return _anotherVar;
			}
			set
			{
				if (_anotherVar == value)
				{
					return;
				}
				_anotherVar = value;
				PropertySet(this);
			}
		}

		public TestStackScriptData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
