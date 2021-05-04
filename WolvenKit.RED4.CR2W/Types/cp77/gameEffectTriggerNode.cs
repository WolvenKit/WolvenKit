using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerNode : worldAreaShapeNode
	{
		private CArray<CHandle<gameEffectTriggerEffectDesc>> _effectDescs;

		[Ordinal(6)] 
		[RED("effectDescs")] 
		public CArray<CHandle<gameEffectTriggerEffectDesc>> EffectDescs
		{
			get => GetProperty(ref _effectDescs);
			set => SetProperty(ref _effectDescs, value);
		}

		public gameEffectTriggerNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
