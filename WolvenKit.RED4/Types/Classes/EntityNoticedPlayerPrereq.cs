using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("isPlayerNoticed")] 
		public CBool IsPlayerNoticed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("valueToListen")] 
		public CUInt32 ValueToListen
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public EntityNoticedPlayerPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
