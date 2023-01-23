using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpperBodyNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCUpperBodyState> ValueToListen
		{
			get => GetPropertyValue<CEnum<gamedataNPCUpperBodyState>>();
			set => SetPropertyValue<CEnum<gamedataNPCUpperBodyState>>(value);
		}

		public UpperBodyNPCStatePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
