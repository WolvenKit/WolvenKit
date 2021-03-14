using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private CEnum<EFastTravelTriggerType> _triggerType;

		[Ordinal(103)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get
			{
				if (_linkedFastTravelPoint == null)
				{
					_linkedFastTravelPoint = (CHandle<gameFastTravelPointData>) CR2WTypeManager.Create("handle:gameFastTravelPointData", "linkedFastTravelPoint", cr2w, this);
				}
				return _linkedFastTravelPoint;
			}
			set
			{
				if (_linkedFastTravelPoint == value)
				{
					return;
				}
				_linkedFastTravelPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("triggerType")] 
		public CEnum<EFastTravelTriggerType> TriggerType
		{
			get
			{
				if (_triggerType == null)
				{
					_triggerType = (CEnum<EFastTravelTriggerType>) CR2WTypeManager.Create("EFastTravelTriggerType", "triggerType", cr2w, this);
				}
				return _triggerType;
			}
			set
			{
				if (_triggerType == value)
				{
					return;
				}
				_triggerType = value;
				PropertySet(this);
			}
		}

		public DataTermControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
