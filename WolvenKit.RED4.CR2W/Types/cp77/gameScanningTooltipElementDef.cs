using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningTooltipElementDef : CVariable
	{
		private TweakDBID _recordID;
		private CFloat _timePct;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(1)] 
		[RED("timePct")] 
		public CFloat TimePct
		{
			get => GetProperty(ref _timePct);
			set => SetProperty(ref _timePct, value);
		}

		public gameScanningTooltipElementDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
