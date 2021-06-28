using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyTabButtonController : TabButtonController
	{
		private CHandle<inkanimProxy> _proxy;
		private CBool _isToggledState;

		[Ordinal(18)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		[Ordinal(19)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get => GetProperty(ref _isToggledState);
			set => SetProperty(ref _isToggledState, value);
		}

		public ProficiencyTabButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
