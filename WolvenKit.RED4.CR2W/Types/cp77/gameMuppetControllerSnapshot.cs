using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllerSnapshot : CVariable
	{
		private CName _controllerId;
		private CBool _isActive;

		[Ordinal(0)] 
		[RED("controllerId")] 
		public CName ControllerId
		{
			get
			{
				if (_controllerId == null)
				{
					_controllerId = (CName) CR2WTypeManager.Create("CName", "controllerId", cr2w, this);
				}
				return _controllerId;
			}
			set
			{
				if (_controllerId == value)
				{
					return;
				}
				_controllerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		public gameMuppetControllerSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
