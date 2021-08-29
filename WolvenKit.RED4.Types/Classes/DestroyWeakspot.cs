using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestroyWeakspot : AIActionHelperTask
	{
		private CInt32 _weakspotIndex;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CArray<CWeakHandle<gameWeakspotObject>> _weakspotArray;

		[Ordinal(5)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetProperty(ref _weakspotIndex);
			set => SetProperty(ref _weakspotIndex, value);
		}

		[Ordinal(6)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetProperty(ref _weakspotComponent);
			set => SetProperty(ref _weakspotComponent, value);
		}

		[Ordinal(7)] 
		[RED("weakspotArray")] 
		public CArray<CWeakHandle<gameWeakspotObject>> WeakspotArray
		{
			get => GetProperty(ref _weakspotArray);
			set => SetProperty(ref _weakspotArray, value);
		}
	}
}
