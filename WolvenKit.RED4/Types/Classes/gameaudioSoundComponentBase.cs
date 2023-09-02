using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameaudioSoundComponentBase : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("audioName")] 
		public CName AudioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("applyObstruction")] 
		public CBool ApplyObstruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("applyAcousticOcclusion")] 
		public CBool ApplyAcousticOcclusion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("applyAcousticRepositioning")] 
		public CBool ApplyAcousticRepositioning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("maxPlayDistance")] 
		public CFloat MaxPlayDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameaudioSoundComponentBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
