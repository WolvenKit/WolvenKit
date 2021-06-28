using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasePerksMenuTooltipData : ATooltipData
	{
		private CHandle<PlayerDevelopmentDataManager> _manager;

		[Ordinal(0)] 
		[RED("manager")] 
		public CHandle<PlayerDevelopmentDataManager> Manager
		{
			get => GetProperty(ref _manager);
			set => SetProperty(ref _manager, value);
		}

		public BasePerksMenuTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
