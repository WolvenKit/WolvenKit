using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class aiscriptSharedVarTarget : RedBaseClass
	{
		private LibTreeSharedVarReferenceName _varName;

		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get => GetProperty(ref _varName);
			set => SetProperty(ref _varName, value);
		}
	}
}
