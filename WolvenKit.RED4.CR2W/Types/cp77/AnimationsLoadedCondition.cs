using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationsLoadedCondition : AIbehaviorconditionScript
	{
		private CBool _coreAnims;
		private CBool _melee;

		[Ordinal(0)] 
		[RED("coreAnims")] 
		public CBool CoreAnims
		{
			get
			{
				if (_coreAnims == null)
				{
					_coreAnims = (CBool) CR2WTypeManager.Create("Bool", "coreAnims", cr2w, this);
				}
				return _coreAnims;
			}
			set
			{
				if (_coreAnims == value)
				{
					return;
				}
				_coreAnims = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("melee")] 
		public CBool Melee
		{
			get
			{
				if (_melee == null)
				{
					_melee = (CBool) CR2WTypeManager.Create("Bool", "melee", cr2w, this);
				}
				return _melee;
			}
			set
			{
				if (_melee == value)
				{
					return;
				}
				_melee = value;
				PropertySet(this);
			}
		}

		public AnimationsLoadedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
