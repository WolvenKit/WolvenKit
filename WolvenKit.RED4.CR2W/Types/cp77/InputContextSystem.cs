using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputContextSystem : gameScriptableSystem
	{
		private CEnum<inputContextType> _activeContext;

		[Ordinal(0)] 
		[RED("activeContext")] 
		public CEnum<inputContextType> ActiveContext
		{
			get => GetProperty(ref _activeContext);
			set => SetProperty(ref _activeContext, value);
		}

		public InputContextSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
