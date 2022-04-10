using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingSquad : PuppetAction
	{
		[Ordinal(25)] 
		[RED("shouldForward")] 
		public CBool ShouldForward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PingSquad()
		{
			ShouldForward = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
