using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		private CFloat _defaultForwardFovRange;
		private CFloat _adjustedForwardFovRange;

		[Ordinal(1)] 
		[RED("defaultForwardFovRange")] 
		public CFloat DefaultForwardFovRange
		{
			get => GetProperty(ref _defaultForwardFovRange);
			set => SetProperty(ref _defaultForwardFovRange, value);
		}

		[Ordinal(2)] 
		[RED("adjustedForwardFovRange")] 
		public CFloat AdjustedForwardFovRange
		{
			get => GetProperty(ref _adjustedForwardFovRange);
			set => SetProperty(ref _adjustedForwardFovRange, value);
		}

		public gameuiBaseDirectionalIndicatorPartLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
