using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleRoadSign : BaseDestructibleDevice
	{
		private CHandle<entMeshComponent> _frameMesh;
		private CHandle<entMeshComponent> _uiMesh;
		private CHandle<entMeshComponent> _uiMesh_2;

		[Ordinal(89)] 
		[RED("frameMesh")] 
		public CHandle<entMeshComponent> FrameMesh
		{
			get
			{
				if (_frameMesh == null)
				{
					_frameMesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "frameMesh", cr2w, this);
				}
				return _frameMesh;
			}
			set
			{
				if (_frameMesh == value)
				{
					return;
				}
				_frameMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("uiMesh")] 
		public CHandle<entMeshComponent> UiMesh
		{
			get
			{
				if (_uiMesh == null)
				{
					_uiMesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "uiMesh", cr2w, this);
				}
				return _uiMesh;
			}
			set
			{
				if (_uiMesh == value)
				{
					return;
				}
				_uiMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("uiMesh_2")] 
		public CHandle<entMeshComponent> UiMesh_2
		{
			get
			{
				if (_uiMesh_2 == null)
				{
					_uiMesh_2 = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "uiMesh_2", cr2w, this);
				}
				return _uiMesh_2;
			}
			set
			{
				if (_uiMesh_2 == value)
				{
					return;
				}
				_uiMesh_2 = value;
				PropertySet(this);
			}
		}

		public DestructibleRoadSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
