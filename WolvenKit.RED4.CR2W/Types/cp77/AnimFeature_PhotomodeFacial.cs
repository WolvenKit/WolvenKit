using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PhotomodeFacial : animAnimFeature
	{
		private CInt32 _facialPoseIndex;

		[Ordinal(0)] 
		[RED("facialPoseIndex")] 
		public CInt32 FacialPoseIndex
		{
			get => GetProperty(ref _facialPoseIndex);
			set => SetProperty(ref _facialPoseIndex, value);
		}

		public AnimFeature_PhotomodeFacial(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
