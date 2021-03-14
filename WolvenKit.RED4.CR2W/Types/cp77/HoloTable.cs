using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloTable : InteractiveDevice
	{
		private CArray<CHandle<entMeshComponent>> _meshTable;
		private CInt32 _componentCounter;
		private CInt32 _currentMesh;
		private CHandle<entMeshComponent> _glitchMesh;

		[Ordinal(93)] 
		[RED("meshTable")] 
		public CArray<CHandle<entMeshComponent>> MeshTable
		{
			get
			{
				if (_meshTable == null)
				{
					_meshTable = (CArray<CHandle<entMeshComponent>>) CR2WTypeManager.Create("array:handle:entMeshComponent", "meshTable", cr2w, this);
				}
				return _meshTable;
			}
			set
			{
				if (_meshTable == value)
				{
					return;
				}
				_meshTable = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("componentCounter")] 
		public CInt32 ComponentCounter
		{
			get
			{
				if (_componentCounter == null)
				{
					_componentCounter = (CInt32) CR2WTypeManager.Create("Int32", "componentCounter", cr2w, this);
				}
				return _componentCounter;
			}
			set
			{
				if (_componentCounter == value)
				{
					return;
				}
				_componentCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("currentMesh")] 
		public CInt32 CurrentMesh
		{
			get
			{
				if (_currentMesh == null)
				{
					_currentMesh = (CInt32) CR2WTypeManager.Create("Int32", "currentMesh", cr2w, this);
				}
				return _currentMesh;
			}
			set
			{
				if (_currentMesh == value)
				{
					return;
				}
				_currentMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("glitchMesh")] 
		public CHandle<entMeshComponent> GlitchMesh
		{
			get
			{
				if (_glitchMesh == null)
				{
					_glitchMesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "glitchMesh", cr2w, this);
				}
				return _glitchMesh;
			}
			set
			{
				if (_glitchMesh == value)
				{
					return;
				}
				_glitchMesh = value;
				PropertySet(this);
			}
		}

		public HoloTable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
