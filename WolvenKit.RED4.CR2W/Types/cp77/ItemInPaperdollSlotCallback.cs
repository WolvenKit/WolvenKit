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
			get
			{
				if (_paperdollPuppet == null)
				{
					_paperdollPuppet = (wCHandle<gamePuppet>) CR2WTypeManager.Create("whandle:gamePuppet", "paperdollPuppet", cr2w, this);
				}
				return _paperdollPuppet;
			}
			set
			{
				if (_paperdollPuppet == value)
				{
					return;
				}
				_paperdollPuppet = value;
				PropertySet(this);
			}
		}

		public ItemInPaperdollSlotCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
