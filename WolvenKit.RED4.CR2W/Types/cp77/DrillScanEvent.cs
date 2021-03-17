using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillScanEvent : redEvent
	{
		private CBool _isScanning;

		[Ordinal(0)] 
		[RED("IsScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}

		public DrillScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
