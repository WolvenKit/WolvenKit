using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDManagerRegistrationTaskData : gameScriptTaskData
	{
		private CBool _shouldRegister;

		[Ordinal(0)] 
		[RED("shouldRegister")] 
		public CBool ShouldRegister
		{
			get => GetProperty(ref _shouldRegister);
			set => SetProperty(ref _shouldRegister, value);
		}
	}
}
