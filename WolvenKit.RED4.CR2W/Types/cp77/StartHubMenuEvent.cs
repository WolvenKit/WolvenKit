using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartHubMenuEvent : redEvent
	{
		private CHandle<HubMenuInitData> _initData;

		[Ordinal(0)] 
		[RED("initData")] 
		public CHandle<HubMenuInitData> InitData
		{
			get
			{
				if (_initData == null)
				{
					_initData = (CHandle<HubMenuInitData>) CR2WTypeManager.Create("handle:HubMenuInitData", "initData", cr2w, this);
				}
				return _initData;
			}
			set
			{
				if (_initData == value)
				{
					return;
				}
				_initData = value;
				PropertySet(this);
			}
		}

		public StartHubMenuEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
