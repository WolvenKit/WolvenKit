using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		private animTransformIndex _hipsIndex;
		private animTransformIndex _leftFootIKIndex;
		private animTransformIndex _rightFootIKIndex;
		private animFloatLink _inputSpeed;
		private animFloatLink _weight;
		private animfssBodyOfflineParams _params;

		[Ordinal(12)] 
		[RED("hipsIndex")] 
		public animTransformIndex HipsIndex
		{
			get
			{
				if (_hipsIndex == null)
				{
					_hipsIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "hipsIndex", cr2w, this);
				}
				return _hipsIndex;
			}
			set
			{
				if (_hipsIndex == value)
				{
					return;
				}
				_hipsIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("leftFootIKIndex")] 
		public animTransformIndex LeftFootIKIndex
		{
			get
			{
				if (_leftFootIKIndex == null)
				{
					_leftFootIKIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "leftFootIKIndex", cr2w, this);
				}
				return _leftFootIKIndex;
			}
			set
			{
				if (_leftFootIKIndex == value)
				{
					return;
				}
				_leftFootIKIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rightFootIKIndex")] 
		public animTransformIndex RightFootIKIndex
		{
			get
			{
				if (_rightFootIKIndex == null)
				{
					_rightFootIKIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "rightFootIKIndex", cr2w, this);
				}
				return _rightFootIKIndex;
			}
			set
			{
				if (_rightFootIKIndex == value)
				{
					return;
				}
				_rightFootIKIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inputSpeed")] 
		public animFloatLink InputSpeed
		{
			get
			{
				if (_inputSpeed == null)
				{
					_inputSpeed = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "inputSpeed", cr2w, this);
				}
				return _inputSpeed;
			}
			set
			{
				if (_inputSpeed == value)
				{
					return;
				}
				_inputSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("Params")] 
		public animfssBodyOfflineParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (animfssBodyOfflineParams) CR2WTypeManager.Create("animfssBodyOfflineParams", "Params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FootStepScaling(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
