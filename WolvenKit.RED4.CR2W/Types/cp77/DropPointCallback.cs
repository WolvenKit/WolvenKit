using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointCallback : gameInventoryScriptCallback
	{
		private wCHandle<DropPointSystem> _dps;

		[Ordinal(1)] 
		[RED("dps")] 
		public wCHandle<DropPointSystem> Dps
		{
			get
			{
				if (_dps == null)
				{
					_dps = (wCHandle<DropPointSystem>) CR2WTypeManager.Create("whandle:DropPointSystem", "dps", cr2w, this);
				}
				return _dps;
			}
			set
			{
				if (_dps == value)
				{
					return;
				}
				_dps = value;
				PropertySet(this);
			}
		}

		public DropPointCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
