using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamBendedRoad : meshMeshParameter
	{
		private CArray<CUInt16> _occInds;
		private CArray<Vector4> _occVerts;
		private CArray<Vector4> _occSkinWeights;
		private CArray<CColor> _occSkinInds;
		private CArray<CArray<CUInt16>> _collInds;
		private CArray<CArray<Vector3>> _collVerts;
		private CArray<CArray<Vector4>> _collSkinWeights;
		private CArray<CArray<CColor>> _collSkinInds;
		private CArray<CString> _collMaterialName;
		private CArray<CString> _collFilterPresetName;
		private CArray<CArray<CUInt16>> _collFaceMatInds;
		private CArray<CArray<CString>> _collFaceMaterialNames;

		[Ordinal(0)] 
		[RED("occInds")] 
		public CArray<CUInt16> OccInds
		{
			get
			{
				if (_occInds == null)
				{
					_occInds = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "occInds", cr2w, this);
				}
				return _occInds;
			}
			set
			{
				if (_occInds == value)
				{
					return;
				}
				_occInds = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("occVerts")] 
		public CArray<Vector4> OccVerts
		{
			get
			{
				if (_occVerts == null)
				{
					_occVerts = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "occVerts", cr2w, this);
				}
				return _occVerts;
			}
			set
			{
				if (_occVerts == value)
				{
					return;
				}
				_occVerts = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("occSkinWeights")] 
		public CArray<Vector4> OccSkinWeights
		{
			get
			{
				if (_occSkinWeights == null)
				{
					_occSkinWeights = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "occSkinWeights", cr2w, this);
				}
				return _occSkinWeights;
			}
			set
			{
				if (_occSkinWeights == value)
				{
					return;
				}
				_occSkinWeights = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("occSkinInds")] 
		public CArray<CColor> OccSkinInds
		{
			get
			{
				if (_occSkinInds == null)
				{
					_occSkinInds = (CArray<CColor>) CR2WTypeManager.Create("array:Color", "occSkinInds", cr2w, this);
				}
				return _occSkinInds;
			}
			set
			{
				if (_occSkinInds == value)
				{
					return;
				}
				_occSkinInds = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("collInds")] 
		public CArray<CArray<CUInt16>> CollInds
		{
			get
			{
				if (_collInds == null)
				{
					_collInds = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "collInds", cr2w, this);
				}
				return _collInds;
			}
			set
			{
				if (_collInds == value)
				{
					return;
				}
				_collInds = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("collVerts")] 
		public CArray<CArray<Vector3>> CollVerts
		{
			get
			{
				if (_collVerts == null)
				{
					_collVerts = (CArray<CArray<Vector3>>) CR2WTypeManager.Create("array:array:Vector3", "collVerts", cr2w, this);
				}
				return _collVerts;
			}
			set
			{
				if (_collVerts == value)
				{
					return;
				}
				_collVerts = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("collSkinWeights")] 
		public CArray<CArray<Vector4>> CollSkinWeights
		{
			get
			{
				if (_collSkinWeights == null)
				{
					_collSkinWeights = (CArray<CArray<Vector4>>) CR2WTypeManager.Create("array:array:Vector4", "collSkinWeights", cr2w, this);
				}
				return _collSkinWeights;
			}
			set
			{
				if (_collSkinWeights == value)
				{
					return;
				}
				_collSkinWeights = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("collSkinInds")] 
		public CArray<CArray<CColor>> CollSkinInds
		{
			get
			{
				if (_collSkinInds == null)
				{
					_collSkinInds = (CArray<CArray<CColor>>) CR2WTypeManager.Create("array:array:Color", "collSkinInds", cr2w, this);
				}
				return _collSkinInds;
			}
			set
			{
				if (_collSkinInds == value)
				{
					return;
				}
				_collSkinInds = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("collMaterialName")] 
		public CArray<CString> CollMaterialName
		{
			get
			{
				if (_collMaterialName == null)
				{
					_collMaterialName = (CArray<CString>) CR2WTypeManager.Create("array:String", "collMaterialName", cr2w, this);
				}
				return _collMaterialName;
			}
			set
			{
				if (_collMaterialName == value)
				{
					return;
				}
				_collMaterialName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("collFilterPresetName")] 
		public CArray<CString> CollFilterPresetName
		{
			get
			{
				if (_collFilterPresetName == null)
				{
					_collFilterPresetName = (CArray<CString>) CR2WTypeManager.Create("array:String", "collFilterPresetName", cr2w, this);
				}
				return _collFilterPresetName;
			}
			set
			{
				if (_collFilterPresetName == value)
				{
					return;
				}
				_collFilterPresetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("collFaceMatInds")] 
		public CArray<CArray<CUInt16>> CollFaceMatInds
		{
			get
			{
				if (_collFaceMatInds == null)
				{
					_collFaceMatInds = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "collFaceMatInds", cr2w, this);
				}
				return _collFaceMatInds;
			}
			set
			{
				if (_collFaceMatInds == value)
				{
					return;
				}
				_collFaceMatInds = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("collFaceMaterialNames")] 
		public CArray<CArray<CString>> CollFaceMaterialNames
		{
			get
			{
				if (_collFaceMaterialNames == null)
				{
					_collFaceMaterialNames = (CArray<CArray<CString>>) CR2WTypeManager.Create("array:array:String", "collFaceMaterialNames", cr2w, this);
				}
				return _collFaceMaterialNames;
			}
			set
			{
				if (_collFaceMaterialNames == value)
				{
					return;
				}
				_collFaceMaterialNames = value;
				PropertySet(this);
			}
		}

		public meshMeshParamBendedRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
