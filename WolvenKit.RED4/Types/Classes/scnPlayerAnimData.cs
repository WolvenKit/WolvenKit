using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayerAnimData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tierData")] 
		public CHandle<gameSceneTierData> TierData
		{
			get => GetPropertyValue<CHandle<gameSceneTierData>>();
			set => SetPropertyValue<CHandle<gameSceneTierData>>(value);
		}

		[Ordinal(1)] 
		[RED("useZSnapping")] 
		public CBool UseZSnapping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("unmountBodyCarry")] 
		public CBool UnmountBodyCarry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scnPlayerAnimData()
		{
			UnmountBodyCarry = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
