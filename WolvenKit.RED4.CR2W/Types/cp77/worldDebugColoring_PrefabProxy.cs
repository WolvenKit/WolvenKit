using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_PrefabProxy : worldEditorDebugColoringSettings
	{
		private CColor _regularMeshColor;
		private CColor _instancedMeshColor;
		private CColor _prefabProxyMeshColor;
		private CBool _distinguishInstancedMesh;

		[Ordinal(0)] 
		[RED("regularMeshColor")] 
		public CColor RegularMeshColor
		{
			get
			{
				if (_regularMeshColor == null)
				{
					_regularMeshColor = (CColor) CR2WTypeManager.Create("Color", "regularMeshColor", cr2w, this);
				}
				return _regularMeshColor;
			}
			set
			{
				if (_regularMeshColor == value)
				{
					return;
				}
				_regularMeshColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instancedMeshColor")] 
		public CColor InstancedMeshColor
		{
			get
			{
				if (_instancedMeshColor == null)
				{
					_instancedMeshColor = (CColor) CR2WTypeManager.Create("Color", "instancedMeshColor", cr2w, this);
				}
				return _instancedMeshColor;
			}
			set
			{
				if (_instancedMeshColor == value)
				{
					return;
				}
				_instancedMeshColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prefabProxyMeshColor")] 
		public CColor PrefabProxyMeshColor
		{
			get
			{
				if (_prefabProxyMeshColor == null)
				{
					_prefabProxyMeshColor = (CColor) CR2WTypeManager.Create("Color", "prefabProxyMeshColor", cr2w, this);
				}
				return _prefabProxyMeshColor;
			}
			set
			{
				if (_prefabProxyMeshColor == value)
				{
					return;
				}
				_prefabProxyMeshColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distinguishInstancedMesh")] 
		public CBool DistinguishInstancedMesh
		{
			get
			{
				if (_distinguishInstancedMesh == null)
				{
					_distinguishInstancedMesh = (CBool) CR2WTypeManager.Create("Bool", "distinguishInstancedMesh", cr2w, this);
				}
				return _distinguishInstancedMesh;
			}
			set
			{
				if (_distinguishInstancedMesh == value)
				{
					return;
				}
				_distinguishInstancedMesh = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_PrefabProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
