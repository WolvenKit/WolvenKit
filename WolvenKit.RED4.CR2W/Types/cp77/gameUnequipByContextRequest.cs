using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameUnequipByContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameItemUnequipContexts> _itemUnequipContext;

		[Ordinal(1)] 
		[RED("itemUnequipContext")] 
		public CEnum<gameItemUnequipContexts> ItemUnequipContext
		{
			get => GetProperty(ref _itemUnequipContext);
			set => SetProperty(ref _itemUnequipContext, value);
		}

		public gameUnequipByContextRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
