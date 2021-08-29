using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Basic_Replicated_Property : RedBaseClass
	{
		private CBool _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CBool Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}
	}
}
