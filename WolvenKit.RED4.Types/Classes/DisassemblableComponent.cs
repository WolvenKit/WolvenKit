using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisassemblableComponent : gameScriptableComponent
	{
		private CBool _disassembled;
		private CArray<CWeakHandle<gameObject>> _disassembleTargetRequesters;

		[Ordinal(5)] 
		[RED("disassembled")] 
		public CBool Disassembled
		{
			get => GetProperty(ref _disassembled);
			set => SetProperty(ref _disassembled, value);
		}

		[Ordinal(6)] 
		[RED("disassembleTargetRequesters")] 
		public CArray<CWeakHandle<gameObject>> DisassembleTargetRequesters
		{
			get => GetProperty(ref _disassembleTargetRequesters);
			set => SetProperty(ref _disassembleTargetRequesters, value);
		}
	}
}
