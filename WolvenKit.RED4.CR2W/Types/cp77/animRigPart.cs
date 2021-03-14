using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRigPart : CVariable
	{
		private CName _name;
		private CArray<animRigPartBone> _singleBones;
		private CArray<animRigPartBoneTree> _treeBones;
		private CArray<CName> _bonesWithRotationInModelSpace;
		private CArray<animTransformMask> _mask;
		private CArray<CInt32> _maskRotMS;

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
		[RED("singleBones")] 
		public CArray<animRigPartBone> SingleBones
		{
			get
			{
				if (_singleBones == null)
				{
					_singleBones = (CArray<animRigPartBone>) CR2WTypeManager.Create("array:animRigPartBone", "singleBones", cr2w, this);
				}
				return _singleBones;
			}
			set
			{
				if (_singleBones == value)
				{
					return;
				}
				_singleBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("treeBones")] 
		public CArray<animRigPartBoneTree> TreeBones
		{
			get
			{
				if (_treeBones == null)
				{
					_treeBones = (CArray<animRigPartBoneTree>) CR2WTypeManager.Create("array:animRigPartBoneTree", "treeBones", cr2w, this);
				}
				return _treeBones;
			}
			set
			{
				if (_treeBones == value)
				{
					return;
				}
				_treeBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bonesWithRotationInModelSpace")] 
		public CArray<CName> BonesWithRotationInModelSpace
		{
			get
			{
				if (_bonesWithRotationInModelSpace == null)
				{
					_bonesWithRotationInModelSpace = (CArray<CName>) CR2WTypeManager.Create("array:CName", "bonesWithRotationInModelSpace", cr2w, this);
				}
				return _bonesWithRotationInModelSpace;
			}
			set
			{
				if (_bonesWithRotationInModelSpace == value)
				{
					return;
				}
				_bonesWithRotationInModelSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mask")] 
		public CArray<animTransformMask> Mask
		{
			get
			{
				if (_mask == null)
				{
					_mask = (CArray<animTransformMask>) CR2WTypeManager.Create("array:animTransformMask", "mask", cr2w, this);
				}
				return _mask;
			}
			set
			{
				if (_mask == value)
				{
					return;
				}
				_mask = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maskRotMS")] 
		public CArray<CInt32> MaskRotMS
		{
			get
			{
				if (_maskRotMS == null)
				{
					_maskRotMS = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "maskRotMS", cr2w, this);
				}
				return _maskRotMS;
			}
			set
			{
				if (_maskRotMS == value)
				{
					return;
				}
				_maskRotMS = value;
				PropertySet(this);
			}
		}

		public animRigPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
