using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_TerminateGameEffect : gameEffectExecutor
	{
		private CBool _onlyWithPlayerInstigator;

		[Ordinal(1)] 
		[RED("onlyWithPlayerInstigator")] 
		public CBool OnlyWithPlayerInstigator
		{
			get
			{
				if (_onlyWithPlayerInstigator == null)
				{
					_onlyWithPlayerInstigator = (CBool) CR2WTypeManager.Create("Bool", "onlyWithPlayerInstigator", cr2w, this);
				}
				return _onlyWithPlayerInstigator;
			}
			set
			{
				if (_onlyWithPlayerInstigator == value)
				{
					return;
				}
				_onlyWithPlayerInstigator = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_TerminateGameEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
