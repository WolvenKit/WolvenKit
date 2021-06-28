using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetIndicatorEntry : CVariable
	{
		private entEntityID _targetID;
		private wCHandle<inkWidget> _indicator;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(1)] 
		[RED("indicator")] 
		public wCHandle<inkWidget> Indicator
		{
			get => GetProperty(ref _indicator);
			set => SetProperty(ref _indicator, value);
		}

		public TargetIndicatorEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
