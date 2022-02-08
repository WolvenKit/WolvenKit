using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
