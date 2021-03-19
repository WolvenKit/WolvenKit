using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSaveEntityData : CVariable
	{
		private entEntityID _entityId;
		private gameGodModeEntityData _data;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameGodModeEntityData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gameGodModeSaveEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
