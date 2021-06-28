using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReflectionEmitterSettings : audioAudioMetadata
	{
		private CName _reflectionEvent;
		private CFloat _fadeout;
		private CFloat _reflectionDeltaThreshold;
		private CUInt32 _maxConcurrentReflections;
		private CUInt32 _broadcastChannel;
		private CBool _listenerRelativePosition;
		private CBool _upReflectionEnabled;
		private CBool _shortReflectionIndoors;
		private CEnum<audioReflectionVariant> _reflectionVariant;
		private CFloat _backReflectionCutoffSpread;
		private CFloat _backReflectionCutoffStrength;
		private CFloat _backReflectionCutoffSoftness;
		private CFloat _farReflectionDistance;
		private CFloat _nearReflectionDistance;
		private CFloat _minimumFaceAlignement;
		private CFloat _fixedRaycastPitch;

		[Ordinal(1)] 
		[RED("reflectionEvent")] 
		public CName ReflectionEvent
		{
			get => GetProperty(ref _reflectionEvent);
			set => SetProperty(ref _reflectionEvent, value);
		}

		[Ordinal(2)] 
		[RED("fadeout")] 
		public CFloat Fadeout
		{
			get => GetProperty(ref _fadeout);
			set => SetProperty(ref _fadeout, value);
		}

		[Ordinal(3)] 
		[RED("reflectionDeltaThreshold")] 
		public CFloat ReflectionDeltaThreshold
		{
			get => GetProperty(ref _reflectionDeltaThreshold);
			set => SetProperty(ref _reflectionDeltaThreshold, value);
		}

		[Ordinal(4)] 
		[RED("maxConcurrentReflections")] 
		public CUInt32 MaxConcurrentReflections
		{
			get => GetProperty(ref _maxConcurrentReflections);
			set => SetProperty(ref _maxConcurrentReflections, value);
		}

		[Ordinal(5)] 
		[RED("broadcastChannel")] 
		public CUInt32 BroadcastChannel
		{
			get => GetProperty(ref _broadcastChannel);
			set => SetProperty(ref _broadcastChannel, value);
		}

		[Ordinal(6)] 
		[RED("listenerRelativePosition")] 
		public CBool ListenerRelativePosition
		{
			get => GetProperty(ref _listenerRelativePosition);
			set => SetProperty(ref _listenerRelativePosition, value);
		}

		[Ordinal(7)] 
		[RED("upReflectionEnabled")] 
		public CBool UpReflectionEnabled
		{
			get => GetProperty(ref _upReflectionEnabled);
			set => SetProperty(ref _upReflectionEnabled, value);
		}

		[Ordinal(8)] 
		[RED("shortReflectionIndoors")] 
		public CBool ShortReflectionIndoors
		{
			get => GetProperty(ref _shortReflectionIndoors);
			set => SetProperty(ref _shortReflectionIndoors, value);
		}

		[Ordinal(9)] 
		[RED("reflectionVariant")] 
		public CEnum<audioReflectionVariant> ReflectionVariant
		{
			get => GetProperty(ref _reflectionVariant);
			set => SetProperty(ref _reflectionVariant, value);
		}

		[Ordinal(10)] 
		[RED("backReflectionCutoffSpread")] 
		public CFloat BackReflectionCutoffSpread
		{
			get => GetProperty(ref _backReflectionCutoffSpread);
			set => SetProperty(ref _backReflectionCutoffSpread, value);
		}

		[Ordinal(11)] 
		[RED("backReflectionCutoffStrength")] 
		public CFloat BackReflectionCutoffStrength
		{
			get => GetProperty(ref _backReflectionCutoffStrength);
			set => SetProperty(ref _backReflectionCutoffStrength, value);
		}

		[Ordinal(12)] 
		[RED("backReflectionCutoffSoftness")] 
		public CFloat BackReflectionCutoffSoftness
		{
			get => GetProperty(ref _backReflectionCutoffSoftness);
			set => SetProperty(ref _backReflectionCutoffSoftness, value);
		}

		[Ordinal(13)] 
		[RED("farReflectionDistance")] 
		public CFloat FarReflectionDistance
		{
			get => GetProperty(ref _farReflectionDistance);
			set => SetProperty(ref _farReflectionDistance, value);
		}

		[Ordinal(14)] 
		[RED("nearReflectionDistance")] 
		public CFloat NearReflectionDistance
		{
			get => GetProperty(ref _nearReflectionDistance);
			set => SetProperty(ref _nearReflectionDistance, value);
		}

		[Ordinal(15)] 
		[RED("minimumFaceAlignement")] 
		public CFloat MinimumFaceAlignement
		{
			get => GetProperty(ref _minimumFaceAlignement);
			set => SetProperty(ref _minimumFaceAlignement, value);
		}

		[Ordinal(16)] 
		[RED("fixedRaycastPitch")] 
		public CFloat FixedRaycastPitch
		{
			get => GetProperty(ref _fixedRaycastPitch);
			set => SetProperty(ref _fixedRaycastPitch, value);
		}

		public audioReflectionEmitterSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
