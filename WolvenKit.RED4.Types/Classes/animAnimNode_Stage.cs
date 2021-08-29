using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Stage : animAnimNode_Container
	{
		private CArray<animPoseLink> _inputPoses;

		[Ordinal(12)] 
		[RED("inputPoses")] 
		public CArray<animPoseLink> InputPoses
		{
			get => GetProperty(ref _inputPoses);
			set => SetProperty(ref _inputPoses, value);
		}
	}
}
