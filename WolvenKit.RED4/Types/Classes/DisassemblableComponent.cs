using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisassemblableComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("disassembled")] 
		public CBool Disassembled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("disassembleTargetRequesters")] 
		public CArray<CWeakHandle<gameObject>> DisassembleTargetRequesters
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameObject>>>(value);
		}

		public DisassemblableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
