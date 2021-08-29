using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Dynamic_Map_Array_Property : RedBaseClass
	{
		private CArray<SampleMapArrayElement> _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CArray<SampleMapArrayElement> Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
