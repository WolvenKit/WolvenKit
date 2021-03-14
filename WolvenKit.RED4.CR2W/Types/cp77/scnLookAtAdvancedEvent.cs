using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtAdvancedEvent : scnSceneEvent
	{
		private scnLookAtAdvancedEventData _advancedData;

		[Ordinal(6)] 
		[RED("advancedData")] 
		public scnLookAtAdvancedEventData AdvancedData
		{
			get
			{
				if (_advancedData == null)
				{
					_advancedData = (scnLookAtAdvancedEventData) CR2WTypeManager.Create("scnLookAtAdvancedEventData", "advancedData", cr2w, this);
				}
				return _advancedData;
			}
			set
			{
				if (_advancedData == value)
				{
					return;
				}
				_advancedData = value;
				PropertySet(this);
			}
		}

		public scnLookAtAdvancedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
