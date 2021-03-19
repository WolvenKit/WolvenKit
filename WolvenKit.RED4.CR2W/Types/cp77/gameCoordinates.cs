using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoordinates : CVariable
	{
		private CInt32 _latitude;
		private CInt32 _longitude;

		[Ordinal(0)] 
		[RED("latitude")] 
		public CInt32 Latitude
		{
			get => GetProperty(ref _latitude);
			set => SetProperty(ref _latitude, value);
		}

		[Ordinal(1)] 
		[RED("longitude")] 
		public CInt32 Longitude
		{
			get => GetProperty(ref _longitude);
			set => SetProperty(ref _longitude, value);
		}

		public gameCoordinates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
