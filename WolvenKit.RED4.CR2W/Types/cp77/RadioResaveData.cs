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
			get => GetProperty(ref _mediaResaveData);
			set => SetProperty(ref _mediaResaveData, value);
		}

		[Ordinal(1)] 
		[RED("stations")] 
		public CArray<RadioStationsMap> Stations
		{
			get => GetProperty(ref _stations);
			set => SetProperty(ref _stations, value);
		}

		public RadioResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
