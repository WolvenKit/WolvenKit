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
			get
			{
				if (_sourceObject == null)
				{
					_sourceObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "sourceObject", cr2w, this);
				}
				return _sourceObject;
			}
			set
			{
				if (_sourceObject == value)
				{
					return;
				}
				_sourceObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sourcePosition")] 
		public Vector4 SourcePosition
		{
			get
			{
				if (_sourcePosition == null)
				{
					_sourcePosition = (Vector4) CR2WTypeManager.Create("Vector4", "sourcePosition", cr2w, this);
				}
				return _sourcePosition;
			}
			set
			{
				if (_sourcePosition == value)
				{
					return;
				}
				_sourcePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("detection")] 
		public CFloat Detection
		{
			get
			{
				if (_detection == null)
				{
					_detection = (CFloat) CR2WTypeManager.Create("Float", "detection", cr2w, this);
				}
				return _detection;
			}
			set
			{
				if (_detection == value)
				{
					return;
				}
				_detection = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<senseStimuliData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<senseStimuliData>) CR2WTypeManager.Create("handle:senseStimuliData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stimTags")] 
		public CArray<CName> StimTags
		{
			get
			{
				if (_stimTags == null)
				{
					_stimTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "stimTags", cr2w, this);
				}
				return _stimTags;
			}
			set
			{
				if (_stimTags == value)
				{
					return;
				}
				_stimTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("movePositions")] 
		public CArray<Vector4> MovePositions
		{
			get
			{
				if (_movePositions == null)
				{
					_movePositions = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "movePositions", cr2w, this);
				}
				return _movePositions;
			}
			set
			{
				if (_movePositions == value)
				{
					return;
				}
				_movePositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("stimPriority")] 
		public CEnum<gamedataStimPriority> StimPriority
		{
			get
			{
				if (_stimPriority == null)
				{
					_stimPriority = (CEnum<gamedataStimPriority>) CR2WTypeManager.Create("gamedataStimPriority", "stimPriority", cr2w, this);
				}
				return _stimPriority;
			}
			set
			{
				if (_stimPriority == value)
				{
					return;
				}
				_stimPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stimPropagation")] 
		public CEnum<gamedataStimPropagation> StimPropagation
		{
			get
			{
				if (_stimPropagation == null)
				{
					_stimPropagation = (CEnum<gamedataStimPropagation>) CR2WTypeManager.Create("gamedataStimPropagation", "stimPropagation", cr2w, this);
				}
				return _stimPropagation;
			}
			set
			{
				if (_stimPropagation == value)
				{
					return;
				}
				_stimPropagation = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("stimCategory")] 
		public CName StimCategory
		{
			get
			{
				if (_stimCategory == null)
				{
					_stimCategory = (CName) CR2WTypeManager.Create("CName", "stimCategory", cr2w, this);
				}
				return _stimCategory;
			}
			set
			{
				if (_stimCategory == value)
				{
					return;
				}
				_stimCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("stimInvestigateData")] 
		public stimInvestigateData StimInvestigateData
		{
			get
			{
				if (_stimInvestigateData == null)
				{
					_stimInvestigateData = (stimInvestigateData) CR2WTypeManager.Create("stimInvestigateData", "stimInvestigateData", cr2w, this);
				}
				return _stimInvestigateData;
			}
			set
			{
				if (_stimInvestigateData == value)
				{
					return;
				}
				_stimInvestigateData = value;
				PropertySet(this);
			}
		}

		public senseStimuliEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
