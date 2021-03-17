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
			get => GetProperty(ref _myCustomNameForProperty);
			set => SetProperty(ref _myCustomNameForProperty, value);
		}

		public Sample_Class_2_10(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
