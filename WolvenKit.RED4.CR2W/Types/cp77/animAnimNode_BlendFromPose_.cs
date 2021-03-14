using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendFromPose_ : animAnimNode_OnePoseInput
	{
		private CFloat _blendTime;
		private CEnum<animEBlendTypeLBC> _blendType;
		private curveData<CFloat> _customBlendCurve;
		private CEnum<animEBlendFromPoseMode> _mode;
		private CName _requestedByTag;

		[Ordinal(12)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("blendType")] 
		public CEnum<animEBlendTypeLBC> BlendType
		{
			get
			{
				if (_blendType == null)
				{
					_blendType = (CEnum<animEBlendTypeLBC>) CR2WTypeManager.Create("animEBlendTypeLBC", "blendType", cr2w, this);
				}
				return _blendType;
			}
			set
			{
				if (_blendType == value)
				{
					return;
				}
				_blendType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("customBlendCurve")] 
		public curveData<CFloat> CustomBlendCurve
		{
			get
			{
				if (_customBlendCurve == null)
				{
					_customBlendCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "customBlendCurve", cr2w, this);
				}
				return _customBlendCurve;
			}
			set
			{
				if (_customBlendCurve == value)
				{
					return;
				}
				_customBlendCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("mode")] 
		public CEnum<animEBlendFromPoseMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<animEBlendFromPoseMode>) CR2WTypeManager.Create("animEBlendFromPoseMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("requestedByTag")] 
		public CName RequestedByTag
		{
			get
			{
				if (_requestedByTag == null)
				{
					_requestedByTag = (CName) CR2WTypeManager.Create("CName", "requestedByTag", cr2w, this);
				}
				return _requestedByTag;
			}
			set
			{
				if (_requestedByTag == value)
				{
					return;
				}
				_requestedByTag = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendFromPose_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
