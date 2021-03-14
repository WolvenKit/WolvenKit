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
			get
			{
				if (_myNameForVariable == null)
				{
					_myNameForVariable = (CHandle<Sample_Class_2_16_0>) CR2WTypeManager.Create("handle:Sample_Class_2_16_0", "MyNameForVariable", cr2w, this);
				}
				return _myNameForVariable;
			}
			set
			{
				if (_myNameForVariable == value)
				{
					return;
				}
				_myNameForVariable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ArrayOfInts")] 
		public CArray<CInt32> ArrayOfInts
		{
			get
			{
				if (_arrayOfInts == null)
				{
					_arrayOfInts = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "ArrayOfInts", cr2w, this);
				}
				return _arrayOfInts;
			}
			set
			{
				if (_arrayOfInts == value)
				{
					return;
				}
				_arrayOfInts = value;
				PropertySet(this);
			}
		}

		public Sample_Class_2_16_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
