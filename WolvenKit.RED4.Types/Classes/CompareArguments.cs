using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompareArguments : AIbehaviorconditionScript
	{
		private CName _var1;
		private CName _var2;

		[Ordinal(0)] 
		[RED("var1")] 
		public CName Var1
		{
			get => GetProperty(ref _var1);
			set => SetProperty(ref _var1, value);
		}

		[Ordinal(1)] 
		[RED("var2")] 
		public CName Var2
		{
			get => GetProperty(ref _var2);
			set => SetProperty(ref _var2, value);
		}
	}
}
