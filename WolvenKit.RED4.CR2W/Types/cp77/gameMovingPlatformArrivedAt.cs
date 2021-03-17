using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformArrivedAt : redEvent
	{
		private CName _destinationName;
		private CInt32 _data;

		[Ordinal(0)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetProperty(ref _destinationName);
			set => SetProperty(ref _destinationName, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CInt32 Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gameMovingPlatformArrivedAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
