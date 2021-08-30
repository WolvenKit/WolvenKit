using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterQuickHacked_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _quickHacked;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("quickHacked")] 
		public CBool QuickHacked
		{
			get => GetProperty(ref _quickHacked);
			set => SetProperty(ref _quickHacked, value);
		}

		public questCharacterQuickHacked_ConditionType()
		{
			_quickHacked = true;
		}
	}
}
