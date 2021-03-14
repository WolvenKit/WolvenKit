using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Stop : questTimeDilation_Operation
	{
		private CName _easeOutCurve;

		[Ordinal(0)] 
		[RED("easeOutCurve")] 
		public CName EaseOutCurve
		{
			get
			{
				if (_easeOutCurve == null)
				{
					_easeOutCurve = (CName) CR2WTypeManager.Create("CName", "easeOutCurve", cr2w, this);
				}
				return _easeOutCurve;
			}
			set
			{
				if (_easeOutCurve == value)
				{
					return;
				}
				_easeOutCurve = value;
				PropertySet(this);
			}
		}

		public questTimeDilation_Stop(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
