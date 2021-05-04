using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_Movement_PredefinedFunction : gameTransformAnimation_Movement
	{
		private EasingFunction _function;

		[Ordinal(0)] 
		[RED("function")] 
		public EasingFunction Function
		{
			get => GetProperty(ref _function);
			set => SetProperty(ref _function, value);
		}

		public gameTransformAnimation_Movement_PredefinedFunction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
