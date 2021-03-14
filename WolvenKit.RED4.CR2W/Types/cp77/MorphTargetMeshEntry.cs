using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMeshEntry : CVariable
	{
		private CName _name;
		private CName _regionName;
		private CEnum<MorphTargetsFaceRegion> _faceRegion;
		private CArray<CName> _boneNames;
		private CArray<CMatrix> _boneRigMatrices;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get
			{
				if (_regionName == null)
				{
					_regionName = (CName) CR2WTypeManager.Create("CName", "regionName", cr2w, this);
				}
				return _regionName;
			}
			set
			{
				if (_regionName == value)
				{
					return;
				}
				_regionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("faceRegion")] 
		public CEnum<MorphTargetsFaceRegion> FaceRegion
		{
			get
			{
				if (_faceRegion == null)
				{
					_faceRegion = (CEnum<MorphTargetsFaceRegion>) CR2WTypeManager.Create("MorphTargetsFaceRegion", "faceRegion", cr2w, this);
				}
				return _faceRegion;
			}
			set
			{
				if (_faceRegion == value)
				{
					return;
				}
				_faceRegion = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get
			{
				if (_boneNames == null)
				{
					_boneNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "boneNames", cr2w, this);
				}
				return _boneNames;
			}
			set
			{
				if (_boneNames == value)
				{
					return;
				}
				_boneNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("boneRigMatrices")] 
		public CArray<CMatrix> BoneRigMatrices
		{
			get
			{
				if (_boneRigMatrices == null)
				{
					_boneRigMatrices = (CArray<CMatrix>) CR2WTypeManager.Create("array:Matrix", "boneRigMatrices", cr2w, this);
				}
				return _boneRigMatrices;
			}
			set
			{
				if (_boneRigMatrices == value)
				{
					return;
				}
				_boneRigMatrices = value;
				PropertySet(this);
			}
		}

		public MorphTargetMeshEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
