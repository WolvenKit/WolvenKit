using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemInPaperdollSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<gamePuppet> _paperdollPuppet;

		[Ordinal(2)] 
		[RED("paperdollPuppet")] 
		public wCHandle<gamePuppet> PaperdollPuppet
		{
			get => GetProperty(ref _paperdollPuppet);
			set => SetProperty(ref _paperdollPuppet, value);
		}

		public ItemInPaperdollSlotCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
