using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrectionGroup : CVariable
	{
		private CStatic<animPoseCorrection> _poseCorrections;

		[Ordinal(0)] 
		[RED("poseCorrections", 2)] 
		public CStatic<animPoseCorrection> PoseCorrections
		{
			get
			{
				if (_poseCorrections == null)
				{
					_poseCorrections = (CStatic<animPoseCorrection>) CR2WTypeManager.Create("static:2,animPoseCorrection", "poseCorrections", cr2w, this);
				}
				return _poseCorrections;
			}
			set
			{
				if (_poseCorrections == value)
				{
					return;
				}
				_poseCorrections = value;
				PropertySet(this);
			}
		}

		public animPoseCorrectionGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
