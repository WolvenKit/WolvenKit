using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SuppressSecuritySystemReaction : redEvent
	{
		private CBool _enableProtection;
		private entEntityID _protectedEntityID;
		private CBool _entered;
		private CBool _hasEntityWithdrawn;

		[Ordinal(0)] 
		[RED("enableProtection")] 
		public CBool EnableProtection
		{
			get
			{
				if (_enableProtection == null)
				{
					_enableProtection = (CBool) CR2WTypeManager.Create("Bool", "enableProtection", cr2w, this);
				}
				return _enableProtection;
			}
			set
			{
				if (_enableProtection == value)
				{
					return;
				}
				_enableProtection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("protectedEntityID")] 
		public entEntityID ProtectedEntityID
		{
			get
			{
				if (_protectedEntityID == null)
				{
					_protectedEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "protectedEntityID", cr2w, this);
				}
				return _protectedEntityID;
			}
			set
			{
				if (_protectedEntityID == value)
				{
					return;
				}
				_protectedEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entered")] 
		public CBool Entered
		{
			get
			{
				if (_entered == null)
				{
					_entered = (CBool) CR2WTypeManager.Create("Bool", "entered", cr2w, this);
				}
				return _entered;
			}
			set
			{
				if (_entered == value)
				{
					return;
				}
				_entered = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasEntityWithdrawn")] 
		public CBool HasEntityWithdrawn
		{
			get
			{
				if (_hasEntityWithdrawn == null)
				{
					_hasEntityWithdrawn = (CBool) CR2WTypeManager.Create("Bool", "hasEntityWithdrawn", cr2w, this);
				}
				return _hasEntityWithdrawn;
			}
			set
			{
				if (_hasEntityWithdrawn == value)
				{
					return;
				}
				_hasEntityWithdrawn = value;
				PropertySet(this);
			}
		}

		public SuppressSecuritySystemReaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
