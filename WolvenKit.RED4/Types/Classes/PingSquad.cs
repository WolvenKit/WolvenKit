using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingSquad : PuppetAction
	{
		[Ordinal(38)] 
		[RED("shouldForward")] 
		public CBool ShouldForward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PingSquad()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
