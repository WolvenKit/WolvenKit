using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioShockwavePropertyMetadata : audioAudioMetadata
	{
		private CName _eventName;
		private CFloat _maxDistance;
		private CFloat _probability;

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		public audioShockwavePropertyMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
