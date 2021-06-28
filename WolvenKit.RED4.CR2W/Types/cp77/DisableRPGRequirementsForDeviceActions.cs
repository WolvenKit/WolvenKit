using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisableRPGRequirementsForDeviceActions : redEvent
	{
		private TweakDBID _action;
		private CBool _disable;

		[Ordinal(0)] 
		[RED("action")] 
		public TweakDBID Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("disable")] 
		public CBool Disable
		{
			get => GetProperty(ref _disable);
			set => SetProperty(ref _disable, value);
		}

		public DisableRPGRequirementsForDeviceActions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
