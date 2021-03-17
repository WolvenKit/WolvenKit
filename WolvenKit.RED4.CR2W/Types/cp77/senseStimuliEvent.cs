using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseStimuliEvent : senseBaseStimuliEvent
	{
		private wCHandle<gameObject> _sourceObject;
		private Vector4 _sourcePosition;
		private CFloat _radius;
		private CFloat _detection;
		private CHandle<senseStimuliData> _data;
		private CUInt32 _id;
		private CEnum<gamedataStimType> _stimType;
		private CArray<CName> _stimTags;
		private CArray<Vector4> _movePositions;
		private CEnum<gamedataStimPriority> _stimPriority;
		private CEnum<gamedataStimPropagation> _stimPropagation;
		private CName _stimCategory;
		private stimInvestigateData _stimInvestigateData;

		[Ordinal(2)] 
		[RED("sourceObject")] 
		public wCHandle<gameObject> SourceObject
		{
			get => GetProperty(ref _sourceObject);
			set => SetProperty(ref _sourceObject, value);
		}

		[Ordinal(3)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetProperty(ref _sourcePosition);
			set => SetProperty(ref _sourcePosition, value);
		}

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(5)] 
		[RED("detection")] 
		public CFloat Detection
		{
			get => GetProperty(ref _detection);
			set => SetProperty(ref _detection, value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<senseStimuliData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(7)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(8)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(9)] 
		[RED("stimTags")] 
		public CArray<CName> StimTags
		{
			get => GetProperty(ref _stimTags);
			set => SetProperty(ref _stimTags, value);
		}

		[Ordinal(10)] 
		[RED("movePositions")] 
		public CArray<Vector4> MovePositions
		{
			get => GetProperty(ref _movePositions);
			set => SetProperty(ref _movePositions, value);
		}

		[Ordinal(11)] 
		[RED("stimPriority")] 
		public CEnum<gamedataStimPriority> StimPriority
		{
			get => GetProperty(ref _stimPriority);
			set => SetProperty(ref _stimPriority, value);
		}

		[Ordinal(12)] 
		[RED("stimPropagation")] 
		public CEnum<gamedataStimPropagation> StimPropagation
		{
			get => GetProperty(ref _stimPropagation);
			set => SetProperty(ref _stimPropagation, value);
		}

		[Ordinal(13)] 
		[RED("stimCategory")] 
		public CName StimCategory
		{
			get => GetProperty(ref _stimCategory);
			set => SetProperty(ref _stimCategory, value);
		}

		[Ordinal(14)] 
		[RED("stimInvestigateData")] 
		public stimInvestigateData StimInvestigateData
		{
			get => GetProperty(ref _stimInvestigateData);
			set => SetProperty(ref _stimInvestigateData, value);
		}

		public senseStimuliEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
