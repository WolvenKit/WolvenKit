using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetHighLevelState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("deathFrameId")] 
		public CUInt32 DeathFrameId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMuppetHighLevelState()
		{
			DeathFrameId = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
