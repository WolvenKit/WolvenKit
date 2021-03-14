using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnIKEvent : scnSceneEvent
	{
		private scnIKEventData _ikData;

		[Ordinal(6)] 
		[RED("ikData")] 
		public scnIKEventData IkData
		{
			get
			{
				if (_ikData == null)
				{
					_ikData = (scnIKEventData) CR2WTypeManager.Create("scnIKEventData", "ikData", cr2w, this);
				}
				return _ikData;
			}
			set
			{
				if (_ikData == value)
				{
					return;
				}
				_ikData = value;
				PropertySet(this);
			}
		}

		public scnIKEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
