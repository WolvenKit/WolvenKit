using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LockReleaseOnHit : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LockReleaseOnHit()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
