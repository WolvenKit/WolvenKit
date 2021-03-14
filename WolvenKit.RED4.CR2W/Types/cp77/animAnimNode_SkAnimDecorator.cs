using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimDecorator : animAnimNode_SkAnim
	{
		private animPoseLink _fallback;

		[Ordinal(30)] 
		[RED("Fallback")] 
		public animPoseLink Fallback
		{
			get
			{
				if (_fallback == null)
				{
					_fallback = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "Fallback", cr2w, this);
				}
				return _fallback;
			}
			set
			{
				if (_fallback == value)
				{
					return;
				}
				_fallback = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkAnimDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
