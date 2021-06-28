using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoopIrritationDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<gameObject> _companion;

		[Ordinal(0)] 
		[RED("companion")] 
		public wCHandle<gameObject> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}

		public CoopIrritationDelayCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
