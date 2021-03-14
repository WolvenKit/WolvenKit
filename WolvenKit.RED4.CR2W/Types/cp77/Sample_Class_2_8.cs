using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_8 : CVariable
	{
		private CArray<CInt32> _array;

		[Ordinal(0)] 
		[RED("array")] 
		public CArray<CInt32> Array
		{
			get
			{
				if (_array == null)
				{
					_array = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "array", cr2w, this);
				}
				return _array;
			}
			set
			{
				if (_array == value)
				{
					return;
				}
				_array = value;
				PropertySet(this);
			}
		}

		public Sample_Class_2_8(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
