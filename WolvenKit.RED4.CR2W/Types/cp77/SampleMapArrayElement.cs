using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleMapArrayElement : CVariable
	{
		private CUInt32 _myKey;
		private CString _someStringProperty;
		private CArray<CString> _someArrayProperty;

		[Ordinal(0)] 
		[RED("myKey")] 
		public CUInt32 MyKey
		{
			get
			{
				if (_myKey == null)
				{
					_myKey = (CUInt32) CR2WTypeManager.Create("Uint32", "myKey", cr2w, this);
				}
				return _myKey;
			}
			set
			{
				if (_myKey == value)
				{
					return;
				}
				_myKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("someStringProperty")] 
		public CString SomeStringProperty
		{
			get
			{
				if (_someStringProperty == null)
				{
					_someStringProperty = (CString) CR2WTypeManager.Create("String", "someStringProperty", cr2w, this);
				}
				return _someStringProperty;
			}
			set
			{
				if (_someStringProperty == value)
				{
					return;
				}
				_someStringProperty = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("someArrayProperty")] 
		public CArray<CString> SomeArrayProperty
		{
			get
			{
				if (_someArrayProperty == null)
				{
					_someArrayProperty = (CArray<CString>) CR2WTypeManager.Create("array:String", "someArrayProperty", cr2w, this);
				}
				return _someArrayProperty;
			}
			set
			{
				if (_someArrayProperty == value)
				{
					return;
				}
				_someArrayProperty = value;
				PropertySet(this);
			}
		}

		public SampleMapArrayElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
