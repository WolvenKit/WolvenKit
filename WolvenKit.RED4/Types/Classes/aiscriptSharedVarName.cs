using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class aiscriptSharedVarName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get => GetPropertyValue<LibTreeSharedVarReferenceName>();
			set => SetPropertyValue<LibTreeSharedVarReferenceName>(value);
		}

		public aiscriptSharedVarName()
		{
			VarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
