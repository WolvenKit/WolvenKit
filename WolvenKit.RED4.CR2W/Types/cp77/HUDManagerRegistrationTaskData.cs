using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerRegistrationTaskData : gameScriptTaskData
	{
		private CBool _shouldRegister;

		[Ordinal(0)] 
		[RED("shouldRegister")] 
		public CBool ShouldRegister
		{
			get => GetProperty(ref _shouldRegister);
			set => SetProperty(ref _shouldRegister, value);
		}

		public HUDManagerRegistrationTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
