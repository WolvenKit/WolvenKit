using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class lookAtPresetGunBaseEvents : LookAtPresetBaseEvents
	{
		private CArray<CHandle<entLookAtAddEvent>> _overrideLookAtEvents;
		private CInt32 _gunState;
		private CBool _originalAttachLeft;
		private CBool _originalAttachRight;

		[Ordinal(3)] 
		[RED("overrideLookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> OverrideLookAtEvents
		{
			get
			{
				if (_overrideLookAtEvents == null)
				{
					_overrideLookAtEvents = (CArray<CHandle<entLookAtAddEvent>>) CR2WTypeManager.Create("array:handle:entLookAtAddEvent", "overrideLookAtEvents", cr2w, this);
				}
				return _overrideLookAtEvents;
			}
			set
			{
				if (_overrideLookAtEvents == value)
				{
					return;
				}
				_overrideLookAtEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("gunState")] 
		public CInt32 GunState
		{
			get
			{
				if (_gunState == null)
				{
					_gunState = (CInt32) CR2WTypeManager.Create("Int32", "gunState", cr2w, this);
				}
				return _gunState;
			}
			set
			{
				if (_gunState == value)
				{
					return;
				}
				_gunState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("originalAttachLeft")] 
		public CBool OriginalAttachLeft
		{
			get
			{
				if (_originalAttachLeft == null)
				{
					_originalAttachLeft = (CBool) CR2WTypeManager.Create("Bool", "originalAttachLeft", cr2w, this);
				}
				return _originalAttachLeft;
			}
			set
			{
				if (_originalAttachLeft == value)
				{
					return;
				}
				_originalAttachLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("originalAttachRight")] 
		public CBool OriginalAttachRight
		{
			get
			{
				if (_originalAttachRight == null)
				{
					_originalAttachRight = (CBool) CR2WTypeManager.Create("Bool", "originalAttachRight", cr2w, this);
				}
				return _originalAttachRight;
			}
			set
			{
				if (_originalAttachRight == value)
				{
					return;
				}
				_originalAttachRight = value;
				PropertySet(this);
			}
		}

		public lookAtPresetGunBaseEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
