using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CCTVCamera : gameObject
	{
		private CHandle<entMeshComponent> _mesh;
		private CHandle<gameCameraComponent> _camera;
		private CBool _isControlled;
		private entEntityID _cachedPuppetID;

		[Ordinal(40)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("camera")] 
		public CHandle<gameCameraComponent> Camera
		{
			get
			{
				if (_camera == null)
				{
					_camera = (CHandle<gameCameraComponent>) CR2WTypeManager.Create("handle:gameCameraComponent", "camera", cr2w, this);
				}
				return _camera;
			}
			set
			{
				if (_camera == value)
				{
					return;
				}
				_camera = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get
			{
				if (_isControlled == null)
				{
					_isControlled = (CBool) CR2WTypeManager.Create("Bool", "isControlled", cr2w, this);
				}
				return _isControlled;
			}
			set
			{
				if (_isControlled == value)
				{
					return;
				}
				_isControlled = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("cachedPuppetID")] 
		public entEntityID CachedPuppetID
		{
			get
			{
				if (_cachedPuppetID == null)
				{
					_cachedPuppetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "cachedPuppetID", cr2w, this);
				}
				return _cachedPuppetID;
			}
			set
			{
				if (_cachedPuppetID == value)
				{
					return;
				}
				_cachedPuppetID = value;
				PropertySet(this);
			}
		}

		public CCTVCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
