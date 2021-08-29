using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_GraphSlot : animAnimNode_Base
	{
		private CName _name;
		private CBool _dontDeactivateInput;
		private animPoseLink _inputLink;

		[Ordinal(11)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(12)] 
		[RED("dontDeactivateInput")] 
		public CBool DontDeactivateInput
		{
			get => GetProperty(ref _dontDeactivateInput);
			set => SetProperty(ref _dontDeactivateInput, value);
		}

		[Ordinal(13)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetProperty(ref _inputLink);
			set => SetProperty(ref _inputLink, value);
		}
	}
}
