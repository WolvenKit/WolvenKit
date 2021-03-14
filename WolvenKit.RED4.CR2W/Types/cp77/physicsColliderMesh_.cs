using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsColliderMesh_ : physicsICollider
	{
		private CArray<CName> _faceMaterials;
		private DataBuffer _compiledGeometryBuffer;

		[Ordinal(8)] 
		[RED("faceMaterials")] 
		public CArray<CName> FaceMaterials
		{
			get
			{
				if (_faceMaterials == null)
				{
					_faceMaterials = (CArray<CName>) CR2WTypeManager.Create("array:CName", "faceMaterials", cr2w, this);
				}
				return _faceMaterials;
			}
			set
			{
				if (_faceMaterials == value)
				{
					return;
				}
				_faceMaterials = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get
			{
				if (_compiledGeometryBuffer == null)
				{
					_compiledGeometryBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledGeometryBuffer", cr2w, this);
				}
				return _compiledGeometryBuffer;
			}
			set
			{
				if (_compiledGeometryBuffer == value)
				{
					return;
				}
				_compiledGeometryBuffer = value;
				PropertySet(this);
			}
		}

		public physicsColliderMesh_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
