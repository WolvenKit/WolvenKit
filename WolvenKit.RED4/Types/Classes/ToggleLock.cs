using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleLock : ActionBool
	{
		[Ordinal(38)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
