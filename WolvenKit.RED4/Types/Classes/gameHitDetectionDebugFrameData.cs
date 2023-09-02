using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitDetectionDebugFrameData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("t")] 
		public CBool T
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("mponent")] 
		public CWeakHandle<gameHitRepresentationComponent> Mponent
		{
			get => GetPropertyValue<CWeakHandle<gameHitRepresentationComponent>>();
			set => SetPropertyValue<CWeakHandle<gameHitRepresentationComponent>>(value);
		}

		[Ordinal(2)] 
		[RED("tTime")] 
		public netTime TTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(3)] 
		[RED("apes")] 
		public CArray<gameHitDetectionDebugFrameDataShapeEntry> Apes
		{
			get => GetPropertyValue<CArray<gameHitDetectionDebugFrameDataShapeEntry>>();
			set => SetPropertyValue<CArray<gameHitDetectionDebugFrameDataShapeEntry>>(value);
		}

		public gameHitDetectionDebugFrameData()
		{
			TTime = new netTime();
			Apes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
