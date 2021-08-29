using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestroyWeakspotEffector : gameEffector
	{
		private CInt32 _weakspotIndex;

		[Ordinal(0)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetProperty(ref _weakspotIndex);
			set => SetProperty(ref _weakspotIndex, value);
		}
	}
}
