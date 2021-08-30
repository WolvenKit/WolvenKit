using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetGender_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CName _gender;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("gender")] 
		public CName Gender
		{
			get => GetProperty(ref _gender);
			set => SetProperty(ref _gender, value);
		}

		public questSetGender_NodeTypeParams()
		{
			_gender = "Female";
		}
	}
}
