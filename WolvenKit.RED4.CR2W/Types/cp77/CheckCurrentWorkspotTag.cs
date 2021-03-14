using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentWorkspotTag : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _tag;

		[Ordinal(0)] 
		[RED("tag")] 
		public CHandle<AIArgumentMapping> Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		public CheckCurrentWorkspotTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
