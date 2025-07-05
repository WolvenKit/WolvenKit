using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TCSTakeOverControlActivate : redEvent
	{
		[Ordinal(0)] 
		[RED("IsQuickhack")] 
		public CBool IsQuickhack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TCSTakeOverControlActivate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
