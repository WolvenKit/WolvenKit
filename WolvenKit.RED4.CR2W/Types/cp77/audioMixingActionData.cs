using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMixingActionData : CVariable
	{
		private CEnum<audioMixingActionType> _actionType;
		private CEnum<locVoiceoverContext> _voContext;
		private CName _tagValue;
		private CFloat _dbOffset;
		private CFloat _distanceRolloffFactor;
		private CName _voEventOverride;
		private CUInt64 _customParametersSetKey;
		private CArray<audioAudSimpleParameter> _customParameters;

		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<audioMixingActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<audioMixingActionType>) CR2WTypeManager.Create("audioMixingActionType", "actionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voContext")] 
		public CEnum<locVoiceoverContext> VoContext
		{
			get
			{
				if (_voContext == null)
				{
					_voContext = (CEnum<locVoiceoverContext>) CR2WTypeManager.Create("locVoiceoverContext", "voContext", cr2w, this);
				}
				return _voContext;
			}
			set
			{
				if (_voContext == value)
				{
					return;
				}
				_voContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tagValue")] 
		public CName TagValue
		{
			get
			{
				if (_tagValue == null)
				{
					_tagValue = (CName) CR2WTypeManager.Create("CName", "tagValue", cr2w, this);
				}
				return _tagValue;
			}
			set
			{
				if (_tagValue == value)
				{
					return;
				}
				_tagValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dbOffset")] 
		public CFloat DbOffset
		{
			get
			{
				if (_dbOffset == null)
				{
					_dbOffset = (CFloat) CR2WTypeManager.Create("Float", "dbOffset", cr2w, this);
				}
				return _dbOffset;
			}
			set
			{
				if (_dbOffset == value)
				{
					return;
				}
				_dbOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("distanceRolloffFactor")] 
		public CFloat DistanceRolloffFactor
		{
			get
			{
				if (_distanceRolloffFactor == null)
				{
					_distanceRolloffFactor = (CFloat) CR2WTypeManager.Create("Float", "distanceRolloffFactor", cr2w, this);
				}
				return _distanceRolloffFactor;
			}
			set
			{
				if (_distanceRolloffFactor == value)
				{
					return;
				}
				_distanceRolloffFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("voEventOverride")] 
		public CName VoEventOverride
		{
			get
			{
				if (_voEventOverride == null)
				{
					_voEventOverride = (CName) CR2WTypeManager.Create("CName", "voEventOverride", cr2w, this);
				}
				return _voEventOverride;
			}
			set
			{
				if (_voEventOverride == value)
				{
					return;
				}
				_voEventOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("customParametersSetKey")] 
		public CUInt64 CustomParametersSetKey
		{
			get
			{
				if (_customParametersSetKey == null)
				{
					_customParametersSetKey = (CUInt64) CR2WTypeManager.Create("Uint64", "customParametersSetKey", cr2w, this);
				}
				return _customParametersSetKey;
			}
			set
			{
				if (_customParametersSetKey == value)
				{
					return;
				}
				_customParametersSetKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("customParameters")] 
		public CArray<audioAudSimpleParameter> CustomParameters
		{
			get
			{
				if (_customParameters == null)
				{
					_customParameters = (CArray<audioAudSimpleParameter>) CR2WTypeManager.Create("array:audioAudSimpleParameter", "customParameters", cr2w, this);
				}
				return _customParameters;
			}
			set
			{
				if (_customParameters == value)
				{
					return;
				}
				_customParameters = value;
				PropertySet(this);
			}
		}

		public audioMixingActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
