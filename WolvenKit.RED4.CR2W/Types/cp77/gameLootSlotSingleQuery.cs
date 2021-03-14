using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootSlotSingleQuery : gameLootSlot
	{
		private TweakDBID _queryTDBID;

		[Ordinal(53)] 
		[RED("queryTDBID")] 
		public TweakDBID QueryTDBID
		{
			get
			{
				if (_queryTDBID == null)
				{
					_queryTDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "queryTDBID", cr2w, this);
				}
				return _queryTDBID;
			}
			set
			{
				if (_queryTDBID == value)
				{
					return;
				}
				_queryTDBID = value;
				PropertySet(this);
			}
		}

		public gameLootSlotSingleQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
