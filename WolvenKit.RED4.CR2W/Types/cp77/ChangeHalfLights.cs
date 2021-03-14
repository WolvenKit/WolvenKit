using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeHalfLights : redEvent
	{
		private CBool _isAuthorization;

		[Ordinal(0)] 
		[RED("isAuthorization")] 
		public CBool IsAuthorization
		{
			get
			{
				if (_isAuthorization == null)
				{
					_isAuthorization = (CBool) CR2WTypeManager.Create("Bool", "isAuthorization", cr2w, this);
				}
				return _isAuthorization;
			}
			set
			{
				if (_isAuthorization == value)
				{
					return;
				}
				_isAuthorization = value;
				PropertySet(this);
			}
		}

		public ChangeHalfLights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
