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
			get => GetProperty(ref _weightLink);
			set => SetProperty(ref _weightLink, value);
		}

		public animAnimNode_SharedMetaPose(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
