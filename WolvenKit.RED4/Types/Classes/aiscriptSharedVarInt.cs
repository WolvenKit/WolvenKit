using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class aiscriptSharedVarInt : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("varName")] 
		public LibTreeSharedVarReferenceName VarName
		{
			get => GetPropertyValue<LibTreeSharedVarReferenceName>();
			set => SetPropertyValue<LibTreeSharedVarReferenceName>(value);
		}

		public aiscriptSharedVarInt()
		{
			VarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
