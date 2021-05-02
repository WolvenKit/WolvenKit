using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectBoneEntries : effectIPlacementEntries
	{
		private CBool _inheritRotation;
		private CArray<effectBoneEntry> _bones;

		[Ordinal(0)] 
		[RED("inheritRotation")] 
		public CBool InheritRotation
		{
			get => GetProperty(ref _inheritRotation);
			set => SetProperty(ref _inheritRotation, value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<effectBoneEntry> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		public effectBoneEntries(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
