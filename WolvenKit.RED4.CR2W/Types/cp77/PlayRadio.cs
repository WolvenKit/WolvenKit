using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayRadio : MusicSettings
	{
		private CEnum<ERadioStationList> _radioStation;

		[Ordinal(1)] 
		[RED("radioStation")] 
		public CEnum<ERadioStationList> RadioStation
		{
			get
			{
				if (_radioStation == null)
				{
					_radioStation = (CEnum<ERadioStationList>) CR2WTypeManager.Create("ERadioStationList", "radioStation", cr2w, this);
				}
				return _radioStation;
			}
			set
			{
				if (_radioStation == value)
				{
					return;
				}
				_radioStation = value;
				PropertySet(this);
			}
		}

		public PlayRadio(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
