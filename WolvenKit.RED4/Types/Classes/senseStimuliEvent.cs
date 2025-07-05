using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseStimuliEvent : senseBaseStimuliEvent
	{
		[Ordinal(2)] 
		[RED("sourceObject")] 
		public CWeakHandle<gameObject> SourceObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("stimInvestigateData")] 
		public senseStimInvestigateData StimInvestigateData
		{
			get => GetPropertyValue<senseStimInvestigateData>();
			set => SetPropertyValue<senseStimInvestigateData>(value);
		}

		[Ordinal(4)] 
		[RED("movePositions")] 
		public CArray<Vector4> MovePositions
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(5)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("stimRecord")] 
		public CWeakHandle<gamedataStim_Record> StimRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStim_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStim_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("detection")] 
		public CFloat Detection
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		[Ordinal(10)] 
		[RED("stimPropagation")] 
		public CEnum<gamedataStimPropagation> StimPropagation
		{
			get => GetPropertyValue<CEnum<gamedataStimPropagation>>();
			set => SetPropertyValue<CEnum<gamedataStimPropagation>>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<senseStimuliData> Data
		{
			get => GetPropertyValue<CHandle<senseStimuliData>>();
			set => SetPropertyValue<CHandle<senseStimuliData>>(value);
		}

		[Ordinal(12)] 
		[RED("purelyDirect")] 
		public CBool PurelyDirect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public senseStimuliEvent()
		{
			StimInvestigateData = new senseStimInvestigateData { DistrationPoint = new Vector4(), AttackInstigatorPosition = new Vector4(), InvestigationSpots = new() };
			MovePositions = new();
			SourcePosition = new Vector4 { W = 1.000000F };
			StimType = Enums.gamedataStimType.Invalid;
			StimPropagation = Enums.gamedataStimPropagation.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
