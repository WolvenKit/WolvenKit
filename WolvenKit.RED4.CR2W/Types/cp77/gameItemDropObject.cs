using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemDropObject : gameLootObject
	{
		private CBool _wasItemInitialized;

		[Ordinal(43)] 
		[RED("wasItemInitialized")] 
		public CBool WasItemInitialized
		{
			get => GetProperty(ref _wasItemInitialized);
			set => SetProperty(ref _wasItemInitialized, value);
		}

		public gameItemDropObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
