using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationSongEventStruct : CVariable
	{
		private CName _radioStationName;
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get
			{
				if (_radioStationName == null)
				{
					_radioStationName = (CName) CR2WTypeManager.Create("CName", "radioStationName", cr2w, this);
				}
				return _radioStationName;
			}
			set
			{
				if (_radioStationName == value)
				{
					return;
				}
				_radioStationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get
			{
				if (_radioSongName == null)
				{
					_radioSongName = (CName) CR2WTypeManager.Create("CName", "radioSongName", cr2w, this);
				}
				return _radioSongName;
			}
			set
			{
				if (_radioSongName == value)
				{
					return;
				}
				_radioSongName = value;
				PropertySet(this);
			}
		}

		public audioRadioStationSongEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
