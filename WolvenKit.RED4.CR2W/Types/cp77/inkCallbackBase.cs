using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackBase : CVariable
	{
		private CName _callbackName;
		private CArray<inkCallbackListener> _listeners;

		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get => GetProperty(ref _callbackName);
			set => SetProperty(ref _callbackName, value);
		}

		[Ordinal(1)] 
		[RED("listeners")] 
		public CArray<inkCallbackListener> Listeners
		{
			get => GetProperty(ref _listeners);
			set => SetProperty(ref _listeners, value);
		}

		public inkCallbackBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
