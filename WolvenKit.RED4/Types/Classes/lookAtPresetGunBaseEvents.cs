using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class lookAtPresetGunBaseEvents : LookAtPresetBaseEvents
	{
		[Ordinal(3)] 
		[RED("overrideLookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> OverrideLookAtEvents
		{
			get => GetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>();
			set => SetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>(value);
		}

		[Ordinal(4)] 
		[RED("gunState")] 
		public CInt32 GunState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("originalAttachLeft")] 
		public CBool OriginalAttachLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("originalAttachRight")] 
		public CBool OriginalAttachRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public lookAtPresetGunBaseEvents()
		{
			LookAtEvents = new();
			OverrideLookAtEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
