using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreen : LcdScreen
	{
		private CUInt32 _timeSystemCallbackID;

		[Ordinal(98)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetProperty(ref _timeSystemCallbackID);
			set => SetProperty(ref _timeSystemCallbackID, value);
		}

		public ApartmentScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
