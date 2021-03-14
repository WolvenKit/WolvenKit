using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrection : CVariable
	{
		private CFloat _rbfCoefficient;
		private CFloat _rbfPowValue;
		private CStatic<animCompareBone> _compareBones;
		private CStatic<animBoneCorrection> _boneCorrections;

		[Ordinal(0)] 
		[RED("rbfCoefficient")] 
		public CFloat RbfCoefficient
		{
			get
			{
				if (_rbfCoefficient == null)
				{
					_rbfCoefficient = (CFloat) CR2WTypeManager.Create("Float", "rbfCoefficient", cr2w, this);
				}
				return _rbfCoefficient;
			}
			set
			{
				if (_rbfCoefficient == value)
				{
					return;
				}
				_rbfCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rbfPowValue")] 
		public CFloat RbfPowValue
		{
			get
			{
				if (_rbfPowValue == null)
				{
					_rbfPowValue = (CFloat) CR2WTypeManager.Create("Float", "rbfPowValue", cr2w, this);
				}
				return _rbfPowValue;
			}
			set
			{
				if (_rbfPowValue == value)
				{
					return;
				}
				_rbfPowValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compareBones", 4)] 
		public CStatic<animCompareBone> CompareBones
		{
			get
			{
				if (_compareBones == null)
				{
					_compareBones = (CStatic<animCompareBone>) CR2WTypeManager.Create("static:4,animCompareBone", "compareBones", cr2w, this);
				}
				return _compareBones;
			}
			set
			{
				if (_compareBones == value)
				{
					return;
				}
				_compareBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boneCorrections", 4)] 
		public CStatic<animBoneCorrection> BoneCorrections
		{
			get
			{
				if (_boneCorrections == null)
				{
					_boneCorrections = (CStatic<animBoneCorrection>) CR2WTypeManager.Create("static:4,animBoneCorrection", "boneCorrections", cr2w, this);
				}
				return _boneCorrections;
			}
			set
			{
				if (_boneCorrections == value)
				{
					return;
				}
				_boneCorrections = value;
				PropertySet(this);
			}
		}

		public animPoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
