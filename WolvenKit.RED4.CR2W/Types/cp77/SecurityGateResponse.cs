using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateResponse : redEvent
	{
		private CBool _scanSuccessful;

		[Ordinal(0)] 
		[RED("scanSuccessful")] 
		public CBool ScanSuccessful
		{
			get => GetProperty(ref _scanSuccessful);
			set => SetProperty(ref _scanSuccessful, value);
		}

		public SecurityGateResponse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
