using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamShadowMeshCreationData : meshMeshParameter
	{
		private CArray<CHandle<physicsICollider>> _geometries;
		private CArray<CInt32> _bonesPerGeometry;

		[Ordinal(0)] 
		[RED("geometries")] 
		public CArray<CHandle<physicsICollider>> Geometries
		{
			get
			{
				if (_geometries == null)
				{
					_geometries = (CArray<CHandle<physicsICollider>>) CR2WTypeManager.Create("array:handle:physicsICollider", "geometries", cr2w, this);
				}
				return _geometries;
			}
			set
			{
				if (_geometries == value)
				{
					return;
				}
				_geometries = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bonesPerGeometry")] 
		public CArray<CInt32> BonesPerGeometry
		{
			get
			{
				if (_bonesPerGeometry == null)
				{
					_bonesPerGeometry = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "bonesPerGeometry", cr2w, this);
				}
				return _bonesPerGeometry;
			}
			set
			{
				if (_bonesPerGeometry == value)
				{
					return;
				}
				_bonesPerGeometry = value;
				PropertySet(this);
			}
		}

		public meshMeshParamShadowMeshCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
