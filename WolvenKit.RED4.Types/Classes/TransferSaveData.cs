using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransferSaveData : IScriptable
	{
		[Ordinal(0)] 
		[RED("saveIndex")] 
		public CInt32 SaveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<TransferSaveAction> Action
		{
			get => GetPropertyValue<CEnum<TransferSaveAction>>();
			set => SetPropertyValue<CEnum<TransferSaveAction>>(value);
		}

		public TransferSaveData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
