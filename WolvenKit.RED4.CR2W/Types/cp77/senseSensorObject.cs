using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseSensorObject : ISerializable
	{
		private TweakDBID _presetID;
		private CFloat _detectionFactor;
		private CFloat _detectionDropFactor;
		private CFloat _detectionCoolDownTime;
		private CFloat _detectionPartCoolDownTime;
		private CBool _hearingEnabled;
		private CEnum<gamedataSenseObjectType> _sensorObjectType;

		[Ordinal(0)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}

		[Ordinal(1)] 
		[RED("detectionFactor")] 
		public CFloat DetectionFactor
		{
			get => GetProperty(ref _detectionFactor);
			set => SetProperty(ref _detectionFactor, value);
		}

		[Ordinal(2)] 
		[RED("detectionDropFactor")] 
		public CFloat DetectionDropFactor
		{
			get => GetProperty(ref _detectionDropFactor);
			set => SetProperty(ref _detectionDropFactor, value);
		}

		[Ordinal(3)] 
		[RED("detectionCoolDownTime")] 
		public CFloat DetectionCoolDownTime
		{
			get => GetProperty(ref _detectionCoolDownTime);
			set => SetProperty(ref _detectionCoolDownTime, value);
		}

		[Ordinal(4)] 
		[RED("detectionPartCoolDownTime")] 
		public CFloat DetectionPartCoolDownTime
		{
			get => GetProperty(ref _detectionPartCoolDownTime);
			set => SetProperty(ref _detectionPartCoolDownTime, value);
		}

		[Ordinal(5)] 
		[RED("hearingEnabled")] 
		public CBool HearingEnabled
		{
			get => GetProperty(ref _hearingEnabled);
			set => SetProperty(ref _hearingEnabled, value);
		}

		[Ordinal(6)] 
		[RED("sensorObjectType")] 
		public CEnum<gamedataSenseObjectType> SensorObjectType
		{
			get => GetProperty(ref _sensorObjectType);
			set => SetProperty(ref _sensorObjectType, value);
		}

		public senseSensorObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
