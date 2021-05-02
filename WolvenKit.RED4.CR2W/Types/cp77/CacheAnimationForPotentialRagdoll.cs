using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CacheAnimationForPotentialRagdoll : RagdollTask
	{
		private CName _currentBehavior;

		[Ordinal(0)] 
		[RED("currentBehavior")] 
		public CName CurrentBehavior
		{
			get => GetProperty(ref _currentBehavior);
			set => SetProperty(ref _currentBehavior, value);
		}

		public CacheAnimationForPotentialRagdoll(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
