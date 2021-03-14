using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealDevicesGridEvent : redEvent
	{
		private CBool _shouldDraw;
		private Vector4 _ownerEntityPosition;
		private gameFxResource _fxDefault;
		private CBool _revealSlave;
		private CBool _revealMaster;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get
			{
				if (_shouldDraw == null)
				{
					_shouldDraw = (CBool) CR2WTypeManager.Create("Bool", "shouldDraw", cr2w, this);
				}
				return _shouldDraw;
			}
			set
			{
				if (_shouldDraw == value)
				{
					return;
				}
				_shouldDraw = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerEntityPosition")] 
		public Vector4 OwnerEntityPosition
		{
			get
			{
				if (_ownerEntityPosition == null)
				{
					_ownerEntityPosition = (Vector4) CR2WTypeManager.Create("Vector4", "ownerEntityPosition", cr2w, this);
				}
				return _ownerEntityPosition;
			}
			set
			{
				if (_ownerEntityPosition == value)
				{
					return;
				}
				_ownerEntityPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fxDefault")] 
		public gameFxResource FxDefault
		{
			get
			{
				if (_fxDefault == null)
				{
					_fxDefault = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "fxDefault", cr2w, this);
				}
				return _fxDefault;
			}
			set
			{
				if (_fxDefault == value)
				{
					return;
				}
				_fxDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get
			{
				if (_revealSlave == null)
				{
					_revealSlave = (CBool) CR2WTypeManager.Create("Bool", "revealSlave", cr2w, this);
				}
				return _revealSlave;
			}
			set
			{
				if (_revealSlave == value)
				{
					return;
				}
				_revealSlave = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get
			{
				if (_revealMaster == null)
				{
					_revealMaster = (CBool) CR2WTypeManager.Create("Bool", "revealMaster", cr2w, this);
				}
				return _revealMaster;
			}
			set
			{
				if (_revealMaster == value)
				{
					return;
				}
				_revealMaster = value;
				PropertySet(this);
			}
		}

		public RevealDevicesGridEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
