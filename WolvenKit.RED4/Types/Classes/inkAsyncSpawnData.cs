using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkAsyncSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parentWidget")] 
		public CWeakHandle<inkCompoundWidget> ParentWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("triggerCallbackAsync")] 
		public CBool TriggerCallbackAsync
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		[Ordinal(4)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkAsyncSpawnData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
