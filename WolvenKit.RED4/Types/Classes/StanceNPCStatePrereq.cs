using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StanceNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCStanceState> ValueToListen
		{
			get => GetPropertyValue<CEnum<gamedataNPCStanceState>>();
			set => SetPropertyValue<CEnum<gamedataNPCStanceState>>(value);
		}

		public StanceNPCStatePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
