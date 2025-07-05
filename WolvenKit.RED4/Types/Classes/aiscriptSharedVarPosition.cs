using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class aiscriptSharedVarPosition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get => GetPropertyValue<LibTreeSharedVarReferenceName>();
			set => SetPropertyValue<LibTreeSharedVarReferenceName>(value);
		}

		public aiscriptSharedVarPosition()
		{
			VarName = new LibTreeSharedVarReferenceName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
