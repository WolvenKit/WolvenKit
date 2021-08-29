using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		private CBool _bool2;

		[Ordinal(1)] 
		[RED("bool2")] 
		public CBool Bool2
		{
			get => GetProperty(ref _bool2);
			set => SetProperty(ref _bool2, value);
		}
	}
}
