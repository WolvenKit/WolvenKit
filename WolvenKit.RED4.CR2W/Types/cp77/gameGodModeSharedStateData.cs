using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSharedStateData : CVariable
	{
		private wCHandle<entEntity> _entity;
		private CInt32 _flags;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public gameGodModeSharedStateData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
