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
			get => GetProperty(ref _myKey);
			set => SetProperty(ref _myKey, value);
		}

		[Ordinal(1)] 
		[RED("someStringProperty")] 
		public CString SomeStringProperty
		{
			get => GetProperty(ref _someStringProperty);
			set => SetProperty(ref _someStringProperty, value);
		}

		[Ordinal(2)] 
		[RED("someArrayProperty")] 
		public CArray<CString> SomeArrayProperty
		{
			get => GetProperty(ref _someArrayProperty);
			set => SetProperty(ref _someArrayProperty, value);
		}

		public SampleMapArrayElement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
