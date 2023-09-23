using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DestroyWeakspot : AIActionHelperTask
	{
		[Ordinal(5)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetPropertyValue<CHandle<gameWeakspotComponent>>();
			set => SetPropertyValue<CHandle<gameWeakspotComponent>>(value);
		}

		[Ordinal(7)] 
		[RED("weakspotArray")] 
		public CArray<CWeakHandle<gameWeakspotObject>> WeakspotArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameWeakspotObject>>>(value);
		}

		public DestroyWeakspot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
