using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAdvertMetadata : audioEmitterMetadata
	{
		private CArray<CName> _advertSoundNames;
		private CFloat _minSilenceTime;
		private CFloat _maxSilenceTime;
		private CFloat _minDistance;
		private CEnum<audioAdvertIndoorFilter> _filter;

		[Ordinal(1)] 
		[RED("advertSoundNames")] 
		public CArray<CName> AdvertSoundNames
		{
			get
			{
				if (_advertSoundNames == null)
				{
					_advertSoundNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "advertSoundNames", cr2w, this);
				}
				return _advertSoundNames;
			}
			set
			{
				if (_advertSoundNames == value)
				{
					return;
				}
				_advertSoundNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minSilenceTime")] 
		public CFloat MinSilenceTime
		{
			get
			{
				if (_minSilenceTime == null)
				{
					_minSilenceTime = (CFloat) CR2WTypeManager.Create("Float", "minSilenceTime", cr2w, this);
				}
				return _minSilenceTime;
			}
			set
			{
				if (_minSilenceTime == value)
				{
					return;
				}
				_minSilenceTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxSilenceTime")] 
		public CFloat MaxSilenceTime
		{
			get
			{
				if (_maxSilenceTime == null)
				{
					_maxSilenceTime = (CFloat) CR2WTypeManager.Create("Float", "maxSilenceTime", cr2w, this);
				}
				return _maxSilenceTime;
			}
			set
			{
				if (_maxSilenceTime == value)
				{
					return;
				}
				_maxSilenceTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "minDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("filter")] 
		public CEnum<audioAdvertIndoorFilter> Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (CEnum<audioAdvertIndoorFilter>) CR2WTypeManager.Create("audioAdvertIndoorFilter", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		public audioAdvertMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
