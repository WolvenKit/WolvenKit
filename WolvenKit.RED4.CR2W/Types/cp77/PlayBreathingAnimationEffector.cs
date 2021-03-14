using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayBreathingAnimationEffector : gameEffector
	{
		private CHandle<AnimFeature_CameraBreathing> _animFeature;
		private CName _animFeatureName;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_CameraBreathing> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_CameraBreathing>) CR2WTypeManager.Create("handle:AnimFeature_CameraBreathing", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get
			{
				if (_animFeatureName == null)
				{
					_animFeatureName = (CName) CR2WTypeManager.Create("CName", "animFeatureName", cr2w, this);
				}
				return _animFeatureName;
			}
			set
			{
				if (_animFeatureName == value)
				{
					return;
				}
				_animFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public PlayBreathingAnimationEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
