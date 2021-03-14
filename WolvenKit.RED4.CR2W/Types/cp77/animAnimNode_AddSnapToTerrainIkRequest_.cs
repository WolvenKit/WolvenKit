using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddSnapToTerrainIkRequest_ : animAnimNode_OnePoseInput
	{
		private animFloatLink _animDeltaZ;
		private animSnapToTerrainIkRequest _leftFootRequest;
		private animSnapToTerrainIkRequest _rightFootRequest;
		private animHipsIkRequest _hipsRequest;

		[Ordinal(13)] 
		[RED("animDeltaZ")] 
		public animFloatLink AnimDeltaZ
		{
			get
			{
				if (_animDeltaZ == null)
				{
					_animDeltaZ = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "animDeltaZ", cr2w, this);
				}
				return _animDeltaZ;
			}
			set
			{
				if (_animDeltaZ == value)
				{
					return;
				}
				_animDeltaZ = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("leftFootRequest")] 
		public animSnapToTerrainIkRequest LeftFootRequest
		{
			get
			{
				if (_leftFootRequest == null)
				{
					_leftFootRequest = (animSnapToTerrainIkRequest) CR2WTypeManager.Create("animSnapToTerrainIkRequest", "leftFootRequest", cr2w, this);
				}
				return _leftFootRequest;
			}
			set
			{
				if (_leftFootRequest == value)
				{
					return;
				}
				_leftFootRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("rightFootRequest")] 
		public animSnapToTerrainIkRequest RightFootRequest
		{
			get
			{
				if (_rightFootRequest == null)
				{
					_rightFootRequest = (animSnapToTerrainIkRequest) CR2WTypeManager.Create("animSnapToTerrainIkRequest", "rightFootRequest", cr2w, this);
				}
				return _rightFootRequest;
			}
			set
			{
				if (_rightFootRequest == value)
				{
					return;
				}
				_rightFootRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("hipsRequest")] 
		public animHipsIkRequest HipsRequest
		{
			get
			{
				if (_hipsRequest == null)
				{
					_hipsRequest = (animHipsIkRequest) CR2WTypeManager.Create("animHipsIkRequest", "hipsRequest", cr2w, this);
				}
				return _hipsRequest;
			}
			set
			{
				if (_hipsRequest == value)
				{
					return;
				}
				_hipsRequest = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AddSnapToTerrainIkRequest_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
