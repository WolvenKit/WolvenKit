using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmorStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<PlayerPuppet> _ownerPuppet;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public wCHandle<PlayerPuppet> OwnerPuppet
		{
			get
			{
				if (_ownerPuppet == null)
				{
					_ownerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "ownerPuppet", cr2w, this);
				}
				return _ownerPuppet;
			}
			set
			{
				if (_ownerPuppet == value)
				{
					return;
				}
				_ownerPuppet = value;
				PropertySet(this);
			}
		}

		public ArmorStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
