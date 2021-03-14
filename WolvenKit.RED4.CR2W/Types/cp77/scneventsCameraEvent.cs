using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private CBool _isBlendIn;
		private CFloat _blendTime;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get
			{
				if (_cameraRef == null)
				{
					_cameraRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "cameraRef", cr2w, this);
				}
				return _cameraRef;
			}
			set
			{
				if (_cameraRef == value)
				{
					return;
				}
				_cameraRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isBlendIn")] 
		public CBool IsBlendIn
		{
			get
			{
				if (_isBlendIn == null)
				{
					_isBlendIn = (CBool) CR2WTypeManager.Create("Bool", "isBlendIn", cr2w, this);
				}
				return _isBlendIn;
			}
			set
			{
				if (_isBlendIn == value)
				{
					return;
				}
				_isBlendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		public scneventsCameraEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
