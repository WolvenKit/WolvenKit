using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputDeviceController : gameScriptableComponent
	{
		private CBool _isStarted;

		[Ordinal(5)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetProperty(ref _isStarted);
			set => SetProperty(ref _isStarted, value);
		}

		public InputDeviceController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
