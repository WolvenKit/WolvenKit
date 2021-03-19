using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCommonEntitySettings : CVariable
	{
		private CName _onAttachEvent;
		private CName _onDetachEvent;
		private CBool _stopAllSoundsOnDetach;

		[Ordinal(0)] 
		[RED("onAttachEvent")] 
		public CName OnAttachEvent
		{
			get => GetProperty(ref _onAttachEvent);
			set => SetProperty(ref _onAttachEvent, value);
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get => GetProperty(ref _onDetachEvent);
			set => SetProperty(ref _onDetachEvent, value);
		}

		[Ordinal(2)] 
		[RED("stopAllSoundsOnDetach")] 
		public CBool StopAllSoundsOnDetach
		{
			get => GetProperty(ref _stopAllSoundsOnDetach);
			set => SetProperty(ref _stopAllSoundsOnDetach, value);
		}

		public audioCommonEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
