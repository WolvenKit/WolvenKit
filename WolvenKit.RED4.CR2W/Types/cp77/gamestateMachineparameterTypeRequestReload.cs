using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeRequestReload : IScriptable
	{
		private wCHandle<gameItemObject> _item;

		[Ordinal(0)] 
		[RED("item")] 
		public wCHandle<gameItemObject> Item
		{
			get
			{
				if (_item == null)
				{
					_item = (wCHandle<gameItemObject>) CR2WTypeManager.Create("whandle:gameItemObject", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeRequestReload(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
