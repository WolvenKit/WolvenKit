using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioEventMetadata : ISerializable
	{
		private CUInt32 _wwiseId;
		private CFloat _maxAttenuation;
		private CFloat _minDuration;
		private CFloat _maxDuration;
		private CBool _isLooping;
		private CArray<CName> _stopActionEvents;
		private CArray<CName> _tags;

		[Ordinal(0)] 
		[RED("wwiseId")] 
		public CUInt32 WwiseId
		{
			get
			{
				if (_wwiseId == null)
				{
					_wwiseId = (CUInt32) CR2WTypeManager.Create("Uint32", "wwiseId", cr2w, this);
				}
				return _wwiseId;
			}
			set
			{
				if (_wwiseId == value)
				{
					return;
				}
				_wwiseId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxAttenuation")] 
		public CFloat MaxAttenuation
		{
			get
			{
				if (_maxAttenuation == null)
				{
					_maxAttenuation = (CFloat) CR2WTypeManager.Create("Float", "maxAttenuation", cr2w, this);
				}
				return _maxAttenuation;
			}
			set
			{
				if (_maxAttenuation == value)
				{
					return;
				}
				_maxAttenuation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minDuration")] 
		public CFloat MinDuration
		{
			get
			{
				if (_minDuration == null)
				{
					_minDuration = (CFloat) CR2WTypeManager.Create("Float", "minDuration", cr2w, this);
				}
				return _minDuration;
			}
			set
			{
				if (_minDuration == value)
				{
					return;
				}
				_minDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get
			{
				if (_maxDuration == null)
				{
					_maxDuration = (CFloat) CR2WTypeManager.Create("Float", "maxDuration", cr2w, this);
				}
				return _maxDuration;
			}
			set
			{
				if (_maxDuration == value)
				{
					return;
				}
				_maxDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isLooping")] 
		public CBool IsLooping
		{
			get
			{
				if (_isLooping == null)
				{
					_isLooping = (CBool) CR2WTypeManager.Create("Bool", "isLooping", cr2w, this);
				}
				return _isLooping;
			}
			set
			{
				if (_isLooping == value)
				{
					return;
				}
				_isLooping = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stopActionEvents")] 
		public CArray<CName> StopActionEvents
		{
			get
			{
				if (_stopActionEvents == null)
				{
					_stopActionEvents = (CArray<CName>) CR2WTypeManager.Create("array:CName", "stopActionEvents", cr2w, this);
				}
				return _stopActionEvents;
			}
			set
			{
				if (_stopActionEvents == value)
				{
					return;
				}
				_stopActionEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		public audioAudioEventMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
