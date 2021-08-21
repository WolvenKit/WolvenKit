using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseStimuliEvent : senseBaseStimuliEvent
	{
		private wCHandle<gameObject> _sourceObject;
		private senseStimInvestigateData _stimInvestigateData;
		private CArray<Vector4> _movePositions;
		private Vector4 _sourcePosition;
		private wCHandle<gamedataStim_Record> _stimRecord;
		private CFloat _radius;
		private CFloat _detection;
		private CEnum<gamedataStimType> _stimType;
		private CEnum<gamedataStimPropagation> _stimPropagation;
		private CHandle<senseStimuliData> _data;
		private CUInt32 _id;

		[Ordinal(2)] 
		[RED("sourceObject")] 
		public wCHandle<gameObject> SourceObject
		{
			get => GetProperty(ref _sourceObject);
			set => SetProperty(ref _sourceObject, value);
		}

		[Ordinal(3)] 
		[RED("stimInvestigateData")] 
		public senseStimInvestigateData StimInvestigateData
		{
			get => GetProperty(ref _stimInvestigateData);
			set => SetProperty(ref _stimInvestigateData, value);
		}

		[Ordinal(4)] 
		[RED("movePositions")] 
		public CArray<Vector4> MovePositions
		{
			get => GetProperty(ref _movePositions);
			set => SetProperty(ref _movePositions, value);
		}

		[Ordinal(5)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetProperty(ref _sourcePosition);
			set => SetProperty(ref _sourcePosition, value);
		}

		[Ordinal(6)] 
		[RED("stimRecord")] 
		public wCHandle<gamedataStim_Record> StimRecord
		{
			get => GetProperty(ref _stimRecord);
			set => SetProperty(ref _stimRecord, value);
		}

		[Ordinal(7)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(8)] 
		[RED("detection")] 
		public CFloat Detection
		{
			get => GetProperty(ref _detection);
			set => SetProperty(ref _detection, value);
		}

		[Ordinal(9)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(10)] 
		[RED("stimPropagation")] 
		public CEnum<gamedataStimPropagation> StimPropagation
		{
			get => GetProperty(ref _stimPropagation);
			set => SetProperty(ref _stimPropagation, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<senseStimuliData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public senseStimuliEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
