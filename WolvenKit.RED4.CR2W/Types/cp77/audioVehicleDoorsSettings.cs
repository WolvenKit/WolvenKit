using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettings : CVariable
	{
		private CName _openEvent;
		private CName _closeEvent;

		[Ordinal(0)] 
		[RED("openEvent")] 
		public CName OpenEvent
		{
			get => GetProperty(ref _openEvent);
			set => SetProperty(ref _openEvent, value);
		}

		[Ordinal(1)] 
		[RED("closeEvent")] 
		public CName CloseEvent
		{
			get => GetProperty(ref _closeEvent);
			set => SetProperty(ref _closeEvent, value);
		}

		public audioVehicleDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
