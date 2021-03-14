using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioResaveData : CVariable
	{
		private MediaResaveData _mediaResaveData;
		private CArray<RadioStationsMap> _stations;

		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get
			{
				if (_mediaResaveData == null)
				{
					_mediaResaveData = (MediaResaveData) CR2WTypeManager.Create("MediaResaveData", "mediaResaveData", cr2w, this);
				}
				return _mediaResaveData;
			}
			set
			{
				if (_mediaResaveData == value)
				{
					return;
				}
				_mediaResaveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get
			{
				if (_stations == null)
				{
					_stations = (CArray<RadioStationsMap>) CR2WTypeManager.Create("array:RadioStationsMap", "stations", cr2w, this);
				}
				return _stations;
			}
			set
			{
				if (_stations == value)
				{
					return;
				}
				_stations = value;
				PropertySet(this);
			}
		}

		public RadioResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
