using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("loadResult")] 
		public CEnum<inkIconResult> LoadResult
		{
			get => GetPropertyValue<CEnum<inkIconResult>>();
			set => SetPropertyValue<CEnum<inkIconResult>>(value);
		}

		[Ordinal(1)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkImageWidget> TargetWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("errorMsg")] 
		public CString ErrorMsg
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("iconSrc")] 
		public TweakDBID IconSrc
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public inkCallbackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
