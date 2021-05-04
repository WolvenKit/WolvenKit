using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintController : inkWidgetLogicController
	{
		private inkWidgetLibraryReference _inputDisplayLibRef;
		private inkCompoundWidgetReference _inputDisplayContainer;
		private inkTextWidgetReference _textWidgetRef;

		[Ordinal(1)] 
		[RED("inputDisplayLibRef")] 
		public inkWidgetLibraryReference InputDisplayLibRef
		{
			get => GetProperty(ref _inputDisplayLibRef);
			set => SetProperty(ref _inputDisplayLibRef, value);
		}

		[Ordinal(2)] 
		[RED("inputDisplayContainer")] 
		public inkCompoundWidgetReference InputDisplayContainer
		{
			get => GetProperty(ref _inputDisplayContainer);
			set => SetProperty(ref _inputDisplayContainer, value);
		}

		[Ordinal(3)] 
		[RED("textWidgetRef")] 
		public inkTextWidgetReference TextWidgetRef
		{
			get => GetProperty(ref _textWidgetRef);
			set => SetProperty(ref _textWidgetRef, value);
		}

		public gameuiInputHintController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
