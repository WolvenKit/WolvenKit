using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqParams : CVariable
	{
		private gameStatsObjectID _objectID;
		private gameStatsObjectID _otherObjectID;
		private CVariant _otherData;

		[Ordinal(0)] 
		[RED("objectID")] 
		public gameStatsObjectID ObjectID
		{
			get
			{
				if (_objectID == null)
				{
					_objectID = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "objectID", cr2w, this);
				}
				return _objectID;
			}
			set
			{
				if (_objectID == value)
				{
					return;
				}
				_objectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("otherObjectID")] 
		public gameStatsObjectID OtherObjectID
		{
			get
			{
				if (_otherObjectID == null)
				{
					_otherObjectID = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "otherObjectID", cr2w, this);
				}
				return _otherObjectID;
			}
			set
			{
				if (_otherObjectID == value)
				{
					return;
				}
				_otherObjectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("otherData")] 
		public CVariant OtherData
		{
			get
			{
				if (_otherData == null)
				{
					_otherData = (CVariant) CR2WTypeManager.Create("Variant", "otherData", cr2w, this);
				}
				return _otherData;
			}
			set
			{
				if (_otherData == value)
				{
					return;
				}
				_otherData = value;
				PropertySet(this);
			}
		}

		public gamePrereqParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
