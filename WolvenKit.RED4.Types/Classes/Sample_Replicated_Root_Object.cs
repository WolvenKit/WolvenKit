using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Root_Object : RedBaseClass
	{
		private CBool _bool;

		[Ordinal(0)] 
		[RED("bool")] 
		public CBool Bool
		{
			get => GetProperty(ref _bool);
			set => SetProperty(ref _bool, value);
		}
	}
}
