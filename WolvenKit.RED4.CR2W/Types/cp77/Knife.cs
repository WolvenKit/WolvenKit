using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Knife : BaseProjectile
	{
		private CBool _collided;

		[Ordinal(51)] 
		[RED("collided")] 
		public CBool Collided
		{
			get
			{
				if (_collided == null)
				{
					_collided = (CBool) CR2WTypeManager.Create("Bool", "collided", cr2w, this);
				}
				return _collided;
			}
			set
			{
				if (_collided == value)
				{
					return;
				}
				_collided = value;
				PropertySet(this);
			}
		}

		public Knife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
