using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplAnimTransformSyncElem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("definitionId")] 
		public CInt32 DefinitionId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("playing")] 
		public CBool Playing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameReplAnimTransformSyncElem()
		{
			DefinitionId = -1;
			CurrentTime = -1.000000F;
			TimeScale = 1.000000F;
			TimesToPlay = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
