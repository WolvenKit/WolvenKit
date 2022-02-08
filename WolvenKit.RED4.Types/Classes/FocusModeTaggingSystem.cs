using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeTaggingSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("taggedListenerCallbacks")] 
		public CArray<CHandle<redCallbackObject>> TaggedListenerCallbacks
		{
			get => GetPropertyValue<CArray<CHandle<redCallbackObject>>>();
			set => SetPropertyValue<CArray<CHandle<redCallbackObject>>>(value);
		}

		public FocusModeTaggingSystem()
		{
			TaggedListenerCallbacks = new();
		}
	}
}
