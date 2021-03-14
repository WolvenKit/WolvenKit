using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isCalling;
		private CBool _sceneStarted;
		private CBool _endingCall;
		private entEntityID _forceLookAt;
		private CBool _forceFollow;

		[Ordinal(103)] 
		[RED("isCalling")] 
		public CBool IsCalling
		{
			get
			{
				if (_isCalling == null)
				{
					_isCalling = (CBool) CR2WTypeManager.Create("Bool", "isCalling", cr2w, this);
				}
				return _isCalling;
			}
			set
			{
				if (_isCalling == value)
				{
					return;
				}
				_isCalling = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("sceneStarted")] 
		public CBool SceneStarted
		{
			get
			{
				if (_sceneStarted == null)
				{
					_sceneStarted = (CBool) CR2WTypeManager.Create("Bool", "sceneStarted", cr2w, this);
				}
				return _sceneStarted;
			}
			set
			{
				if (_sceneStarted == value)
				{
					return;
				}
				_sceneStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("endingCall")] 
		public CBool EndingCall
		{
			get
			{
				if (_endingCall == null)
				{
					_endingCall = (CBool) CR2WTypeManager.Create("Bool", "endingCall", cr2w, this);
				}
				return _endingCall;
			}
			set
			{
				if (_endingCall == value)
				{
					return;
				}
				_endingCall = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("forceLookAt")] 
		public entEntityID ForceLookAt
		{
			get
			{
				if (_forceLookAt == null)
				{
					_forceLookAt = (entEntityID) CR2WTypeManager.Create("entEntityID", "forceLookAt", cr2w, this);
				}
				return _forceLookAt;
			}
			set
			{
				if (_forceLookAt == value)
				{
					return;
				}
				_forceLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("forceFollow")] 
		public CBool ForceFollow
		{
			get
			{
				if (_forceFollow == null)
				{
					_forceFollow = (CBool) CR2WTypeManager.Create("Bool", "forceFollow", cr2w, this);
				}
				return _forceFollow;
			}
			set
			{
				if (_forceFollow == value)
				{
					return;
				}
				_forceFollow = value;
				PropertySet(this);
			}
		}

		public IntercomControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
