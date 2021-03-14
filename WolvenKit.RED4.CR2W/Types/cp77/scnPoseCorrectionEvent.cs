using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPoseCorrectionEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private animPoseCorrectionGroup _poseCorrectionGroup;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get
			{
				if (_poseCorrectionGroup == null)
				{
					_poseCorrectionGroup = (animPoseCorrectionGroup) CR2WTypeManager.Create("animPoseCorrectionGroup", "poseCorrectionGroup", cr2w, this);
				}
				return _poseCorrectionGroup;
			}
			set
			{
				if (_poseCorrectionGroup == value)
				{
					return;
				}
				_poseCorrectionGroup = value;
				PropertySet(this);
			}
		}

		public scnPoseCorrectionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
