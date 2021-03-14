using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		private CBool _carrying;

		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get
			{
				if (_carrying == null)
				{
					_carrying = (CBool) CR2WTypeManager.Create("Bool", "carrying", cr2w, this);
				}
				return _carrying;
			}
			set
			{
				if (_carrying == value)
				{
					return;
				}
				_carrying = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SceneSystemCarrying(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
