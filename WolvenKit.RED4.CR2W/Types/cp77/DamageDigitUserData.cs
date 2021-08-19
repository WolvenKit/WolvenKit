using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitUserData : IScriptable
	{
		private CInt32 _controllerIndex;

		[Ordinal(0)] 
		[RED("controllerIndex")] 
		public CInt32 ControllerIndex
		{
			get => GetProperty(ref _controllerIndex);
			set => SetProperty(ref _controllerIndex, value);
		}

		public DamageDigitUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
