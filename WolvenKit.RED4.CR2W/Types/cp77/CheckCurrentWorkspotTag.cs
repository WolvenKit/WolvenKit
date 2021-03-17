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
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		public CheckCurrentWorkspotTag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
