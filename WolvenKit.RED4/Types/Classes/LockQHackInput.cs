using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LockQHackInput : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LockQHackInput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
