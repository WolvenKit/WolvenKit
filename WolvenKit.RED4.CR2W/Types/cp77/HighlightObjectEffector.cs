using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightObjectEffector : gameEffector
	{
		private CName _reason;

		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		public HighlightObjectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
