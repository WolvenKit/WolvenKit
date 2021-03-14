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

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get
			{
				if (_additiveType == null)
				{
					_additiveType = (CEnum<animEAnimGraphAdditiveType>) CR2WTypeManager.Create("animEAnimGraphAdditiveType", "additiveType", cr2w, this);
				}
				return _additiveType;
			}
			set
			{
				if (_additiveType == value)
				{
					return;
				}
				_additiveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get
			{
				if (_blendTracks == null)
				{
					_blendTracks = (CEnum<animEBlendTracksMode>) CR2WTypeManager.Create("animEBlendTracksMode", "blendTracks", cr2w, this);
				}
				return _blendTracks;
			}
			set
			{
				if (_blendTracks == value)
				{
					return;
				}
				_blendTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("convertParentPoseToAdditive")] 
		public CBool ConvertParentPoseToAdditive
		{
			get
			{
				if (_convertParentPoseToAdditive == null)
				{
					_convertParentPoseToAdditive = (CBool) CR2WTypeManager.Create("Bool", "convertParentPoseToAdditive", cr2w, this);
				}
				return _convertParentPoseToAdditive;
			}
			set
			{
				if (_convertParentPoseToAdditive == value)
				{
					return;
				}
				_convertParentPoseToAdditive = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SharedMetaPoseAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
