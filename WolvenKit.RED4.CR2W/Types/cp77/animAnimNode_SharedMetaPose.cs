using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SharedMetaPose : animAnimNode_OnePoseInput
	{
		private animFloatLink _weightLink;

		[Ordinal(12)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get
			{
				if (_weightLink == null)
				{
					_weightLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightLink", cr2w, this);
				}
				return _weightLink;
			}
			set
			{
				if (_weightLink == value)
				{
					return;
				}
				_weightLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SharedMetaPose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
