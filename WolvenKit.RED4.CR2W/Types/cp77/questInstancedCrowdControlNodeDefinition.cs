using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInstancedCrowdControlNodeDefinition : questDisableableNodeDefinition
	{
		private CName _crowdVariantTag;
		private CBool _enable;

		[Ordinal(2)] 
		[RED("crowdVariantTag")] 
		public CName CrowdVariantTag
		{
			get => GetProperty(ref _crowdVariantTag);
			set => SetProperty(ref _crowdVariantTag, value);
		}

		[Ordinal(3)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questInstancedCrowdControlNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
