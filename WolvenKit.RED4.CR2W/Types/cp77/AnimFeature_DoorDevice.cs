using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DoorDevice : animAnimFeature
	{
		private CBool _isOpen;
		private CBool _isLocked;
		private CBool _isSealed;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSealed")] 
		public CBool IsSealed
		{
			get
			{
				if (_isSealed == null)
				{
					_isSealed = (CBool) CR2WTypeManager.Create("Bool", "isSealed", cr2w, this);
				}
				return _isSealed;
			}
			set
			{
				if (_isSealed == value)
				{
					return;
				}
				_isSealed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_DoorDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
