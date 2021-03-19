using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnManagerNodeType : questIRetNodeType
	{
		private CEnum<populationSpawnerObjectCtrlAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<populationSpawnerObjectCtrlAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		public questSpawnManagerNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
