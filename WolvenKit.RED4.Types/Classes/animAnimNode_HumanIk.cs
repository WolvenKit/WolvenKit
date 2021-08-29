using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_HumanIk : animAnimNode_OnePoseInput
	{
		private CArray<animTEMP_IKTargetsControllerBodyType> _ikTargetsControllers;

		[Ordinal(12)] 
		[RED("ikTargetsControllers")] 
		public CArray<animTEMP_IKTargetsControllerBodyType> IkTargetsControllers
		{
			get => GetProperty(ref _ikTargetsControllers);
			set => SetProperty(ref _ikTargetsControllers, value);
		}
	}
}
