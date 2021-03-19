using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SharedMetaPoseAdditive : animAnimNode_OnePoseInput
	{
		private animFloatLink _weightLink;
		private CEnum<animEAnimGraphAdditiveType> _additiveType;
		private CEnum<animEBlendTracksMode> _blendTracks;
		private CBool _convertParentPoseToAdditive;

		[Ordinal(12)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetProperty(ref _weightLink);
			set => SetProperty(ref _weightLink, value);
		}

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get => GetProperty(ref _additiveType);
			set => SetProperty(ref _additiveType, value);
		}

		[Ordinal(14)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get => GetProperty(ref _blendTracks);
			set => SetProperty(ref _blendTracks, value);
		}

		[Ordinal(15)] 
		[RED("convertParentPoseToAdditive")] 
		public CBool ConvertParentPoseToAdditive
		{
			get => GetProperty(ref _convertParentPoseToAdditive);
			set => SetProperty(ref _convertParentPoseToAdditive, value);
		}

		public animAnimNode_SharedMetaPoseAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
