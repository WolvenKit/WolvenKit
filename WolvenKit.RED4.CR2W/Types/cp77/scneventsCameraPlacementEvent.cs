using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsCameraPlacementEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private Transform _cameraTransformLS;

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
		[RED("cameraTransformLS")] 
		public Transform CameraTransformLS
		{
			get
			{
				if (_cameraTransformLS == null)
				{
					_cameraTransformLS = (Transform) CR2WTypeManager.Create("Transform", "cameraTransformLS", cr2w, this);
				}
				return _cameraTransformLS;
			}
			set
			{
				if (_cameraTransformLS == value)
				{
					return;
				}
				_cameraTransformLS = value;
				PropertySet(this);
			}
		}

		public scneventsCameraPlacementEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
