using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_NPCExploration : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("explorationType")] 
		public CInt32 ExplorationType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("movementType")] 
		public CInt32 MovementType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("isEvenLoop")] 
		public CBool IsEvenLoop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("playbackTime")] 
		public CFloat PlaybackTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_NPCExploration()
		{
			IsEvenLoop = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
