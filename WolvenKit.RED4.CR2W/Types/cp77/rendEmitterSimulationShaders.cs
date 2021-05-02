using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendEmitterSimulationShaders : CVariable
	{
		private CArrayFixedSize<DataBuffer> _simCS;

		[Ordinal(0)] 
		[RED("simCS", 2)] 
		public CArrayFixedSize<DataBuffer> SimCS
		{
			get => GetProperty(ref _simCS);
			set => SetProperty(ref _simCS, value);
		}

		public rendEmitterSimulationShaders(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
