using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorSystemUIPS : VirtualSystemPS
	{
		[Ordinal(111)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DoorSystemUIPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
