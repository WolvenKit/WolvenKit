using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_VisualEffectAtTarget : gameEffectExecutor_Scripted
	{
		private gameFxResource _effect;
		private CBool _ignoreTimeDilation;

		[Ordinal(1)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreTimeDilation")] 
		public CBool IgnoreTimeDilation
		{
			get
			{
				if (_ignoreTimeDilation == null)
				{
					_ignoreTimeDilation = (CBool) CR2WTypeManager.Create("Bool", "ignoreTimeDilation", cr2w, this);
				}
				return _ignoreTimeDilation;
			}
			set
			{
				if (_ignoreTimeDilation == value)
				{
					return;
				}
				_ignoreTimeDilation = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_VisualEffectAtTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
