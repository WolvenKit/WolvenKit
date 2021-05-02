using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffect : gameStatusEffectBase
	{
		private CUInt32 _durationID;
		private CArray<CHandle<gameStatModifierData>> _durationModifiers;
		private CArray<CHandle<gameStatModifierData>> _stackModifiers;
		private CArray<CHandle<gameStatModifierData>> _removeAllStacksWhenDurationEndsModifiers;
		private CFloat _duration;
		private CFloat _remainingDuration;
		private CUInt32 _maxStacks;
		private CArray<gameSourceData> _sourcesData;
		private CFloat _initialApplicationTimestamp;
		private CFloat _lastApplicationTimestamp;
		private entEntityID _ownerEntityID;
		private TweakDBID _instigatorRecordID;
		private entEntityID _instigatorEntityID;
		private Vector4 _direction;
		private CBool _removeAllStacksWhenDurationEnds;
		private CName _applicationSource;

		[Ordinal(1)] 
		[RED("durationID")] 
		public CUInt32 DurationID
		{
			get => GetProperty(ref _durationID);
			set => SetProperty(ref _durationID, value);
		}

		[Ordinal(2)] 
		[RED("durationModifiers")] 
		public CArray<CHandle<gameStatModifierData>> DurationModifiers
		{
			get => GetProperty(ref _durationModifiers);
			set => SetProperty(ref _durationModifiers, value);
		}

		[Ordinal(3)] 
		[RED("stackModifiers")] 
		public CArray<CHandle<gameStatModifierData>> StackModifiers
		{
			get => GetProperty(ref _stackModifiers);
			set => SetProperty(ref _stackModifiers, value);
		}

		[Ordinal(4)] 
		[RED("removeAllStacksWhenDurationEndsModifiers")] 
		public CArray<CHandle<gameStatModifierData>> RemoveAllStacksWhenDurationEndsModifiers
		{
			get => GetProperty(ref _removeAllStacksWhenDurationEndsModifiers);
			set => SetProperty(ref _removeAllStacksWhenDurationEndsModifiers, value);
		}

		[Ordinal(5)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(6)] 
		[RED("remainingDuration")] 
		public CFloat RemainingDuration
		{
			get => GetProperty(ref _remainingDuration);
			set => SetProperty(ref _remainingDuration, value);
		}

		[Ordinal(7)] 
		[RED("maxStacks")] 
		public CUInt32 MaxStacks
		{
			get => GetProperty(ref _maxStacks);
			set => SetProperty(ref _maxStacks, value);
		}

		[Ordinal(8)] 
		[RED("sourcesData")] 
		public CArray<gameSourceData> SourcesData
		{
			get => GetProperty(ref _sourcesData);
			set => SetProperty(ref _sourcesData, value);
		}

		[Ordinal(9)] 
		[RED("initialApplicationTimestamp")] 
		public CFloat InitialApplicationTimestamp
		{
			get => GetProperty(ref _initialApplicationTimestamp);
			set => SetProperty(ref _initialApplicationTimestamp, value);
		}

		[Ordinal(10)] 
		[RED("lastApplicationTimestamp")] 
		public CFloat LastApplicationTimestamp
		{
			get => GetProperty(ref _lastApplicationTimestamp);
			set => SetProperty(ref _lastApplicationTimestamp, value);
		}

		[Ordinal(11)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetProperty(ref _ownerEntityID);
			set => SetProperty(ref _ownerEntityID, value);
		}

		[Ordinal(12)] 
		[RED("instigatorRecordID")] 
		public TweakDBID InstigatorRecordID
		{
			get => GetProperty(ref _instigatorRecordID);
			set => SetProperty(ref _instigatorRecordID, value);
		}

		[Ordinal(13)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get => GetProperty(ref _instigatorEntityID);
			set => SetProperty(ref _instigatorEntityID, value);
		}

		[Ordinal(14)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(15)] 
		[RED("removeAllStacksWhenDurationEnds")] 
		public CBool RemoveAllStacksWhenDurationEnds
		{
			get => GetProperty(ref _removeAllStacksWhenDurationEnds);
			set => SetProperty(ref _removeAllStacksWhenDurationEnds, value);
		}

		[Ordinal(16)] 
		[RED("applicationSource")] 
		public CName ApplicationSource
		{
			get => GetProperty(ref _applicationSource);
			set => SetProperty(ref _applicationSource, value);
		}

		public gameStatusEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
