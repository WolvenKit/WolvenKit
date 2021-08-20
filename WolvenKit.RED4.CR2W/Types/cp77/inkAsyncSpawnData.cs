using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkAsyncSpawnData : IScriptable
	{
		private CName _libraryID;
		private wCHandle<inkCompoundWidget> _parentWidget;
		private CBool _triggerCallbackAsync;
		private CHandle<IScriptable> _userData;
		private CName _introAnimation;

		[Ordinal(0)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetProperty(ref _libraryID);
			set => SetProperty(ref _libraryID, value);
		}

		[Ordinal(1)] 
		[RED("parentWidget")] 
		public wCHandle<inkCompoundWidget> ParentWidget
		{
			get => GetProperty(ref _parentWidget);
			set => SetProperty(ref _parentWidget, value);
		}

		[Ordinal(2)] 
		[RED("triggerCallbackAsync")] 
		public CBool TriggerCallbackAsync
		{
			get => GetProperty(ref _triggerCallbackAsync);
			set => SetProperty(ref _triggerCallbackAsync, value);
		}

		[Ordinal(3)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(4)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		public inkAsyncSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
