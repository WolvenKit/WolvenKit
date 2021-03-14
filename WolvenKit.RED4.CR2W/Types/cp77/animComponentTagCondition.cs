using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animComponentTagCondition : animIStaticCondition
	{
		private CName _animTag;

		[Ordinal(0)] 
		[RED("animTag")] 
		public CName AnimTag
		{
			get
			{
				if (_animTag == null)
				{
					_animTag = (CName) CR2WTypeManager.Create("CName", "animTag", cr2w, this);
				}
				return _animTag;
			}
			set
			{
				if (_animTag == value)
				{
					return;
				}
				_animTag = value;
				PropertySet(this);
			}
		}

		public animComponentTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
