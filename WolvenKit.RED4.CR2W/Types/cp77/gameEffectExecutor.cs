using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor : gameEffectNode
	{
		private CBool _usesHitCooldown;

		[Ordinal(0)] 
		[RED("usesHitCooldown")] 
		public CBool UsesHitCooldown
		{
			get => GetProperty(ref _usesHitCooldown);
			set => SetProperty(ref _usesHitCooldown, value);
		}

		public gameEffectExecutor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
