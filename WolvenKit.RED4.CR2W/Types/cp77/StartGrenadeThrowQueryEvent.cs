using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StartGrenadeThrowQueryEvent : redEvent
	{
		private gameGrenadeThrowQueryParams _queryParams;

		[Ordinal(0)] 
		[RED("queryParams")] 
		public gameGrenadeThrowQueryParams QueryParams
		{
			get
			{
				if (_queryParams == null)
				{
					_queryParams = (gameGrenadeThrowQueryParams) CR2WTypeManager.Create("gameGrenadeThrowQueryParams", "queryParams", cr2w, this);
				}
				return _queryParams;
			}
			set
			{
				if (_queryParams == value)
				{
					return;
				}
				_queryParams = value;
				PropertySet(this);
			}
		}

		public StartGrenadeThrowQueryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
