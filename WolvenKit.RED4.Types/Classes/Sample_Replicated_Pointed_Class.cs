using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Pointed_Class : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("property")] 
		public CBool Property
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
