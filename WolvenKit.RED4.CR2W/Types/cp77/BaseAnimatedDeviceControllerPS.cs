using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseAnimatedDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isActive;
		private CBool _hasInteraction;
		private CBool _randomizeAnimationTime;
		private TweakDBID _nameForActivation;
		private TweakDBID _nameForDeactivation;

		[Ordinal(103)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get
			{
				if (_hasInteraction == null)
				{
					_hasInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasInteraction", cr2w, this);
				}
				return _hasInteraction;
			}
			set
			{
				if (_hasInteraction == value)
				{
					return;
				}
				_hasInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("randomizeAnimationTime")] 
		public CBool RandomizeAnimationTime
		{
			get
			{
				if (_randomizeAnimationTime == null)
				{
					_randomizeAnimationTime = (CBool) CR2WTypeManager.Create("Bool", "randomizeAnimationTime", cr2w, this);
				}
				return _randomizeAnimationTime;
			}
			set
			{
				if (_randomizeAnimationTime == value)
				{
					return;
				}
				_randomizeAnimationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("nameForActivation")] 
		public TweakDBID NameForActivation
		{
			get
			{
				if (_nameForActivation == null)
				{
					_nameForActivation = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForActivation", cr2w, this);
				}
				return _nameForActivation;
			}
			set
			{
				if (_nameForActivation == value)
				{
					return;
				}
				_nameForActivation = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("nameForDeactivation")] 
		public TweakDBID NameForDeactivation
		{
			get
			{
				if (_nameForDeactivation == null)
				{
					_nameForDeactivation = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForDeactivation", cr2w, this);
				}
				return _nameForDeactivation;
			}
			set
			{
				if (_nameForDeactivation == value)
				{
					return;
				}
				_nameForDeactivation = value;
				PropertySet(this);
			}
		}

		public BaseAnimatedDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
