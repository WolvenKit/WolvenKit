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
			get
			{
				if (_usesHitCooldown == null)
				{
					_usesHitCooldown = (CBool) CR2WTypeManager.Create("Bool", "usesHitCooldown", cr2w, this);
				}
				return _usesHitCooldown;
			}
			set
			{
				if (_usesHitCooldown == value)
				{
					return;
				}
				_usesHitCooldown = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
