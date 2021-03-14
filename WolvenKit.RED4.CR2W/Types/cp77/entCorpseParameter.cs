using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entCorpseParameter : entEntityParameter
	{
		private CUInt32 _lod;
		private CArray<QsTransform> _bones;
		private CArray<raRef<animRig>> _rigs;
		private CArray<QsTransform> _bakedPose;
		private CArray<CName> _bakedBoneNames;

		[Ordinal(0)] 
		[RED("lod")] 
		public CUInt32 Lod
		{
			get
			{
				if (_lod == null)
				{
					_lod = (CUInt32) CR2WTypeManager.Create("Uint32", "lod", cr2w, this);
				}
				return _lod;
			}
			set
			{
				if (_lod == value)
				{
					return;
				}
				_lod = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<QsTransform> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rigs")] 
		public CArray<raRef<animRig>> Rigs
		{
			get
			{
				if (_rigs == null)
				{
					_rigs = (CArray<raRef<animRig>>) CR2WTypeManager.Create("array:raRef:animRig", "rigs", cr2w, this);
				}
				return _rigs;
			}
			set
			{
				if (_rigs == value)
				{
					return;
				}
				_rigs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bakedPose")] 
		public CArray<QsTransform> BakedPose
		{
			get
			{
				if (_bakedPose == null)
				{
					_bakedPose = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "bakedPose", cr2w, this);
				}
				return _bakedPose;
			}
			set
			{
				if (_bakedPose == value)
				{
					return;
				}
				_bakedPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bakedBoneNames")] 
		public CArray<CName> BakedBoneNames
		{
			get
			{
				if (_bakedBoneNames == null)
				{
					_bakedBoneNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "bakedBoneNames", cr2w, this);
				}
				return _bakedBoneNames;
			}
			set
			{
				if (_bakedBoneNames == value)
				{
					return;
				}
				_bakedBoneNames = value;
				PropertySet(this);
			}
		}

		public entCorpseParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
