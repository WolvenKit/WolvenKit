using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_10 : CVariable
	{
		private CFloat _myCustomNameForProperty;

		[Ordinal(0)] 
		[RED("MyCustomNameForProperty")] 
		public CFloat MyCustomNameForProperty
		{
			get
			{
				if (_myCustomNameForProperty == null)
				{
					_myCustomNameForProperty = (CFloat) CR2WTypeManager.Create("Float", "MyCustomNameForProperty", cr2w, this);
				}
				return _myCustomNameForProperty;
			}
			set
			{
				if (_myCustomNameForProperty == value)
				{
					return;
				}
				_myCustomNameForProperty = value;
				PropertySet(this);
			}
		}

		public Sample_Class_2_10(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
