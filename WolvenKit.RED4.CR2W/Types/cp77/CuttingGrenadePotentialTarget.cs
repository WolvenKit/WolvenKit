using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CuttingGrenadePotentialTarget : CVariable
	{
		private wCHandle<ScriptedPuppet> _entity;
		private CInt32 _hits;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<ScriptedPuppet> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("hits")] 
		public CInt32 Hits
		{
			get => GetProperty(ref _hits);
			set => SetProperty(ref _hits, value);
		}

		public CuttingGrenadePotentialTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
