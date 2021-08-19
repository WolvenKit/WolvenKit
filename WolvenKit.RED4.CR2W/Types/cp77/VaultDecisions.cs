using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VaultDecisions : LocomotionGroundDecisions
	{
		private CBool _stateBodyDone;

		[Ordinal(3)] 
		[RED("stateBodyDone")] 
		public CBool StateBodyDone
		{
			get => GetProperty(ref _stateBodyDone);
			set => SetProperty(ref _stateBodyDone, value);
		}

		public VaultDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
