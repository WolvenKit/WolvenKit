using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartedUsingHealingItemOrCyberwarePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("curValue")] 
		public CUInt32 CurValue
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public StartedUsingHealingItemOrCyberwarePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
