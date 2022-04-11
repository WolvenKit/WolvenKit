using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorSystemUIPS : VirtualSystemPS
	{
		[Ordinal(108)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
