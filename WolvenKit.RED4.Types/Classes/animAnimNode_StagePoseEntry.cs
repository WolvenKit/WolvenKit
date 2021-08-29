using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		private CName _inputName;
		private animPoseLink _parentInput;

		[Ordinal(11)] 
		[RED("inputName")] 
		public CName InputName
		{
			get => GetProperty(ref _inputName);
			set => SetProperty(ref _inputName, value);
		}

		[Ordinal(12)] 
		[RED("parentInput")] 
		public animPoseLink ParentInput
		{
			get => GetProperty(ref _parentInput);
			set => SetProperty(ref _parentInput, value);
		}
	}
}
