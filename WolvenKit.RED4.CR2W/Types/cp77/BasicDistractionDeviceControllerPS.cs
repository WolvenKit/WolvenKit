using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CEnum<EPlaystyleType> _distractorType;
		private CHandle<EngDemoContainer> _basicDistractionDeviceSkillChecks;
		private CArray<CName> _effectOnSartNames;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceAnimationSystem;

		[Ordinal(103)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get
			{
				if (_distractorType == null)
				{
					_distractorType = (CEnum<EPlaystyleType>) CR2WTypeManager.Create("EPlaystyleType", "distractorType", cr2w, this);
				}
				return _distractorType;
			}
			set
			{
				if (_distractorType == value)
				{
					return;
				}
				_distractorType = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get
			{
				if (_basicDistractionDeviceSkillChecks == null)
				{
					_basicDistractionDeviceSkillChecks = (CHandle<EngDemoContainer>) CR2WTypeManager.Create("handle:EngDemoContainer", "basicDistractionDeviceSkillChecks", cr2w, this);
				}
				return _basicDistractionDeviceSkillChecks;
			}
			set
			{
				if (_basicDistractionDeviceSkillChecks == value)
				{
					return;
				}
				_basicDistractionDeviceSkillChecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("effectOnSartNames")] 
		public CArray<CName> EffectOnSartNames
		{
			get
			{
				if (_effectOnSartNames == null)
				{
					_effectOnSartNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "effectOnSartNames", cr2w, this);
				}
				return _effectOnSartNames;
			}
			set
			{
				if (_effectOnSartNames == value)
				{
					return;
				}
				_effectOnSartNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get
			{
				if (_forceAnimationSystem == null)
				{
					_forceAnimationSystem = (CBool) CR2WTypeManager.Create("Bool", "forceAnimationSystem", cr2w, this);
				}
				return _forceAnimationSystem;
			}
			set
			{
				if (_forceAnimationSystem == value)
				{
					return;
				}
				_forceAnimationSystem = value;
				PropertySet(this);
			}
		}

		public BasicDistractionDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
