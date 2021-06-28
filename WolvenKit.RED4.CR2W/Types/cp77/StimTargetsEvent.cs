using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimTargetsEvent : redEvent
	{
		private CArray<StimTargetData> _targets;
		private CBool _restore;

		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<StimTargetData> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(1)] 
		[RED("restore")] 
		public CBool Restore
		{
			get => GetProperty(ref _restore);
			set => SetProperty(ref _restore, value);
		}

		public StimTargetsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
