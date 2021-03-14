using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestMappinScriptData : gamemappinsMappinScriptData
	{
		private CInt32 _test;

		[Ordinal(1)] 
		[RED("test")] 
		public CInt32 Test
		{
			get
			{
				if (_test == null)
				{
					_test = (CInt32) CR2WTypeManager.Create("Int32", "test", cr2w, this);
				}
				return _test;
			}
			set
			{
				if (_test == value)
				{
					return;
				}
				_test = value;
				PropertySet(this);
			}
		}

		public TestMappinScriptData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
