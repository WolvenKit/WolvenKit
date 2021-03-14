using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialInitialPoseWeightDesc : CVariable
	{
		private CArray<CName> _poseNames;
		private CArray<CFloat> _weights;

		[Ordinal(0)] 
		[RED("poseNames")] 
		public CArray<CName> PoseNames
		{
			get
			{
				if (_poseNames == null)
				{
					_poseNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "poseNames", cr2w, this);
				}
				return _poseNames;
			}
			set
			{
				if (_poseNames == value)
				{
					return;
				}
				_poseNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get
			{
				if (_weights == null)
				{
					_weights = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "weights", cr2w, this);
				}
				return _weights;
			}
			set
			{
				if (_weights == value)
				{
					return;
				}
				_weights = value;
				PropertySet(this);
			}
		}

		public animImportFacialInitialPoseWeightDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
