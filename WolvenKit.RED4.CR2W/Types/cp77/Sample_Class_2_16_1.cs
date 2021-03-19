using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_16_1 : CVariable
	{
		private CHandle<Sample_Class_2_16_0> _myNameForVariable;
		private CArray<CInt32> _arrayOfInts;

		[Ordinal(0)] 
		[RED("MyNameForVariable")] 
		public CHandle<Sample_Class_2_16_0> MyNameForVariable
		{
			get => GetProperty(ref _myNameForVariable);
			set => SetProperty(ref _myNameForVariable, value);
		}

		[Ordinal(1)] 
		[RED("ArrayOfInts")] 
		public CArray<CInt32> ArrayOfInts
		{
			get => GetProperty(ref _arrayOfInts);
			set => SetProperty(ref _arrayOfInts, value);
		}

		public Sample_Class_2_16_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
