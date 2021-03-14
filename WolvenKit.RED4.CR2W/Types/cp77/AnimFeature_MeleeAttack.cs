using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_MeleeAttack : animAnimFeature
	{
		private CBool _hit;

		[Ordinal(0)] 
		[RED("hit")] 
		public CBool Hit
		{
			get
			{
				if (_hit == null)
				{
					_hit = (CBool) CR2WTypeManager.Create("Bool", "hit", cr2w, this);
				}
				return _hit;
			}
			set
			{
				if (_hit == value)
				{
					return;
				}
				_hit = value;
				PropertySet(this);
			}
		}

		public AnimFeature_MeleeAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
