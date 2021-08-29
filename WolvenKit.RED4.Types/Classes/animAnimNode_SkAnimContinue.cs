using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkAnimContinue : animAnimNode_SkAnim
	{
		private animPoseLink _input;
		private CName _popSafeCutTag;

		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		[Ordinal(31)] 
		[RED("popSafeCutTag")] 
		public CName PopSafeCutTag
		{
			get => GetProperty(ref _popSafeCutTag);
			set => SetProperty(ref _popSafeCutTag, value);
		}
	}
}
