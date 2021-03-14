using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkAnimSlot : animAnimNode_SkAnim
	{
		private CBool _forFacialIdle;

		[Ordinal(30)] 
		[RED("forFacialIdle")] 
		public CBool ForFacialIdle
		{
			get
			{
				if (_forFacialIdle == null)
				{
					_forFacialIdle = (CBool) CR2WTypeManager.Create("Bool", "forFacialIdle", cr2w, this);
				}
				return _forFacialIdle;
			}
			set
			{
				if (_forFacialIdle == value)
				{
					return;
				}
				_forFacialIdle = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkAnimSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
