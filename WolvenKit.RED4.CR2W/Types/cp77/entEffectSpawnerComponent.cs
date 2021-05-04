using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEffectSpawnerComponent : entIVisualComponent
	{
		private CArray<CHandle<entEffectDesc>> _effectDescs;

		[Ordinal(8)] 
		[RED("effectDescs")] 
		public CArray<CHandle<entEffectDesc>> EffectDescs
		{
			get => GetProperty(ref _effectDescs);
			set => SetProperty(ref _effectDescs, value);
		}

		public entEffectSpawnerComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
