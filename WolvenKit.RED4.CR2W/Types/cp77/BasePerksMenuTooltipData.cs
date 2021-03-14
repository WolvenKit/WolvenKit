using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasePerksMenuTooltipData : ATooltipData
	{
		private CHandle<PlayerDevelopmentDataManager> _manager;

		[Ordinal(0)] 
		[RED("manager")] 
		public CHandle<PlayerDevelopmentDataManager> Manager
		{
			get
			{
				if (_manager == null)
				{
					_manager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "manager", cr2w, this);
				}
				return _manager;
			}
			set
			{
				if (_manager == value)
				{
					return;
				}
				_manager = value;
				PropertySet(this);
			}
		}

		public BasePerksMenuTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
