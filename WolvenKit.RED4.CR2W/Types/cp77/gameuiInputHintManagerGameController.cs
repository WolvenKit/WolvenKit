using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintManagerGameController : gameuiWidgetGameController
	{
		private CName _hintContainerId;
		private inkCompoundWidgetReference _baseGroupContainer;
		private inkCompoundWidgetReference _groupsContainer;
		private inkWidgetLibraryReference _hintLibRef;
		private inkWidgetLibraryReference _groupLibRef;

		[Ordinal(2)] 
		[RED("hintContainerId")] 
		public CName HintContainerId
		{
			get => GetProperty(ref _hintContainerId);
			set => SetProperty(ref _hintContainerId, value);
		}

		[Ordinal(3)] 
		[RED("baseGroupContainer")] 
		public inkCompoundWidgetReference BaseGroupContainer
		{
			get => GetProperty(ref _baseGroupContainer);
			set => SetProperty(ref _baseGroupContainer, value);
		}

		[Ordinal(4)] 
		[RED("groupsContainer")] 
		public inkCompoundWidgetReference GroupsContainer
		{
			get => GetProperty(ref _groupsContainer);
			set => SetProperty(ref _groupsContainer, value);
		}

		[Ordinal(5)] 
		[RED("hintLibRef")] 
		public inkWidgetLibraryReference HintLibRef
		{
			get => GetProperty(ref _hintLibRef);
			set => SetProperty(ref _hintLibRef, value);
		}

		[Ordinal(6)] 
		[RED("groupLibRef")] 
		public inkWidgetLibraryReference GroupLibRef
		{
			get => GetProperty(ref _groupLibRef);
			set => SetProperty(ref _groupLibRef, value);
		}

		public gameuiInputHintManagerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
