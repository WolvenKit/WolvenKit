using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		private CName _facialAnimName;

		[Ordinal(3)] 
		[RED("facialAnimName")] 
		public CName FacialAnimName
		{
			get
			{
				if (_facialAnimName == null)
				{
					_facialAnimName = (CName) CR2WTypeManager.Create("CName", "facialAnimName", cr2w, this);
				}
				return _facialAnimName;
			}
			set
			{
				if (_facialAnimName == value)
				{
					return;
				}
				_facialAnimName = value;
				PropertySet(this);
			}
		}

		public animAnimEvent_WorkspotPlayFacialAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
