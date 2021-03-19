using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Stage : animAnimNode_Container
	{
		private CArray<animPoseLink> _inputPoses;

		[Ordinal(12)] 
		[RED("inputPoses")] 
		public CArray<animPoseLink> InputPoses
		{
			get => GetProperty(ref _inputPoses);
			set => SetProperty(ref _inputPoses, value);
		}

		public animAnimNode_Stage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
