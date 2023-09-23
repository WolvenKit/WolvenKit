using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MonoWireQuickHackApplyEffector : AbstractApplyQuickhackEffector
	{
		[Ordinal(2)] 
		[RED("hasSpreadWindowBeenOpened")] 
		public CBool HasSpreadWindowBeenOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("targetsToSpreadQuickhack")] 
		public CArray<CHandle<MonowireSpreadableNPC>> TargetsToSpreadQuickhack
		{
			get => GetPropertyValue<CArray<CHandle<MonowireSpreadableNPC>>>();
			set => SetPropertyValue<CArray<CHandle<MonowireSpreadableNPC>>>(value);
		}

		[Ordinal(4)] 
		[RED("timeOfPossibleSpread")] 
		public CFloat TimeOfPossibleSpread
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("spreadWindowTime")] 
		public CFloat SpreadWindowTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("spreadCallbackID")] 
		public gameDelayID SpreadCallbackID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public MonoWireQuickHackApplyEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
