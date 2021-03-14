using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWorldLayerDefinition : inkLayerDefinition
	{
		private Vector2 _projectionPlaneSize;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CBool _isInteractableFromBehind;
		private CFloat _maxInteractionDistance;
		private CBool _useCustomFaceVector;
		private Vector3 _faceVector;

		[Ordinal(8)] 
		[RED("projectionPlaneSize")] 
		public Vector2 ProjectionPlaneSize
		{
			get
			{
				if (_projectionPlaneSize == null)
				{
					_projectionPlaneSize = (Vector2) CR2WTypeManager.Create("Vector2", "projectionPlaneSize", cr2w, this);
				}
				return _projectionPlaneSize;
			}
			set
			{
				if (_projectionPlaneSize == value)
				{
					return;
				}
				_projectionPlaneSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get
			{
				if (_renderingPlane == null)
				{
					_renderingPlane = (CEnum<ERenderingPlane>) CR2WTypeManager.Create("ERenderingPlane", "renderingPlane", cr2w, this);
				}
				return _renderingPlane;
			}
			set
			{
				if (_renderingPlane == value)
				{
					return;
				}
				_renderingPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isInteractableFromBehind")] 
		public CBool IsInteractableFromBehind
		{
			get
			{
				if (_isInteractableFromBehind == null)
				{
					_isInteractableFromBehind = (CBool) CR2WTypeManager.Create("Bool", "isInteractableFromBehind", cr2w, this);
				}
				return _isInteractableFromBehind;
			}
			set
			{
				if (_isInteractableFromBehind == value)
				{
					return;
				}
				_isInteractableFromBehind = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("maxInteractionDistance")] 
		public CFloat MaxInteractionDistance
		{
			get
			{
				if (_maxInteractionDistance == null)
				{
					_maxInteractionDistance = (CFloat) CR2WTypeManager.Create("Float", "maxInteractionDistance", cr2w, this);
				}
				return _maxInteractionDistance;
			}
			set
			{
				if (_maxInteractionDistance == value)
				{
					return;
				}
				_maxInteractionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useCustomFaceVector")] 
		public CBool UseCustomFaceVector
		{
			get
			{
				if (_useCustomFaceVector == null)
				{
					_useCustomFaceVector = (CBool) CR2WTypeManager.Create("Bool", "useCustomFaceVector", cr2w, this);
				}
				return _useCustomFaceVector;
			}
			set
			{
				if (_useCustomFaceVector == value)
				{
					return;
				}
				_useCustomFaceVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("faceVector")] 
		public Vector3 FaceVector
		{
			get
			{
				if (_faceVector == null)
				{
					_faceVector = (Vector3) CR2WTypeManager.Create("Vector3", "faceVector", cr2w, this);
				}
				return _faceVector;
			}
			set
			{
				if (_faceVector == value)
				{
					return;
				}
				_faceVector = value;
				PropertySet(this);
			}
		}

		public inkWorldLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
