using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuickItemsManager_NodeType : questIUIManagerNodeType
	{
		private CEnum<questQuickItemsSet> _set;

		[Ordinal(0)] 
		[RED("set")] 
		public CEnum<questQuickItemsSet> Set
		{
			get => GetProperty(ref _set);
			set => SetProperty(ref _set, value);
		}

		public questQuickItemsManager_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
