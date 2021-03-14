using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEvent : scnSceneEvent
	{
		private scnLookAtBasicEventData _basicData;

		[Ordinal(6)] 
		[RED("basicData")] 
		public scnLookAtBasicEventData BasicData
		{
			get
			{
				if (_basicData == null)
				{
					_basicData = (scnLookAtBasicEventData) CR2WTypeManager.Create("scnLookAtBasicEventData", "basicData", cr2w, this);
				}
				return _basicData;
			}
			set
			{
				if (_basicData == value)
				{
					return;
				}
				_basicData = value;
				PropertySet(this);
			}
		}

		public scnLookAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
