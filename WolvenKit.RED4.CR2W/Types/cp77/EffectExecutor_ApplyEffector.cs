using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_ApplyEffector : gameEffectExecutor_Scripted
	{
		private TweakDBID _effector;

		[Ordinal(1)] 
		[RED("effector")] 
		public TweakDBID Effector
		{
			get
			{
				if (_effector == null)
				{
					_effector = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "effector", cr2w, this);
				}
				return _effector;
			}
			set
			{
				if (_effector == value)
				{
					return;
				}
				_effector = value;
				PropertySet(this);
			}
		}

		public EffectExecutor_ApplyEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
