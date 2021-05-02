using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillerScanEvent : redEvent
	{
		private CBool _newIsScanning;

		[Ordinal(0)] 
		[RED("newIsScanning")] 
		public CBool NewIsScanning
		{
			get => GetProperty(ref _newIsScanning);
			set => SetProperty(ref _newIsScanning, value);
		}

		public DrillerScanEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
