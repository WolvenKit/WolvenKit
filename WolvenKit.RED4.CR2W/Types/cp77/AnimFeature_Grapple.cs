using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Grapple : animAnimFeature
	{
		private CBool _inGrapple;

		[Ordinal(0)] 
		[RED("inGrapple")] 
		public CBool InGrapple
		{
			get
			{
				if (_inGrapple == null)
				{
					_inGrapple = (CBool) CR2WTypeManager.Create("Bool", "inGrapple", cr2w, this);
				}
				return _inGrapple;
			}
			set
			{
				if (_inGrapple == value)
				{
					return;
				}
				_inGrapple = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Grapple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
