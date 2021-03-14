using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_IconicItem : animAnimFeature
	{
		private CBool _isScanning;
		private CBool _isFreeDrilling;
		private CBool _isActiveDrilling;
		private CBool _isScanToInteraction;
		private CBool _isItemEquipped;

		[Ordinal(0)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get
			{
				if (_isScanning == null)
				{
					_isScanning = (CBool) CR2WTypeManager.Create("Bool", "isScanning", cr2w, this);
				}
				return _isScanning;
			}
			set
			{
				if (_isScanning == value)
				{
					return;
				}
				_isScanning = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isFreeDrilling")] 
		public CBool IsFreeDrilling
		{
			get
			{
				if (_isFreeDrilling == null)
				{
					_isFreeDrilling = (CBool) CR2WTypeManager.Create("Bool", "isFreeDrilling", cr2w, this);
				}
				return _isFreeDrilling;
			}
			set
			{
				if (_isFreeDrilling == value)
				{
					return;
				}
				_isFreeDrilling = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isActiveDrilling")] 
		public CBool IsActiveDrilling
		{
			get
			{
				if (_isActiveDrilling == null)
				{
					_isActiveDrilling = (CBool) CR2WTypeManager.Create("Bool", "isActiveDrilling", cr2w, this);
				}
				return _isActiveDrilling;
			}
			set
			{
				if (_isActiveDrilling == value)
				{
					return;
				}
				_isActiveDrilling = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isScanToInteraction")] 
		public CBool IsScanToInteraction
		{
			get
			{
				if (_isScanToInteraction == null)
				{
					_isScanToInteraction = (CBool) CR2WTypeManager.Create("Bool", "isScanToInteraction", cr2w, this);
				}
				return _isScanToInteraction;
			}
			set
			{
				if (_isScanToInteraction == value)
				{
					return;
				}
				_isScanToInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isItemEquipped")] 
		public CBool IsItemEquipped
		{
			get
			{
				if (_isItemEquipped == null)
				{
					_isItemEquipped = (CBool) CR2WTypeManager.Create("Bool", "isItemEquipped", cr2w, this);
				}
				return _isItemEquipped;
			}
			set
			{
				if (_isItemEquipped == value)
				{
					return;
				}
				_isItemEquipped = value;
				PropertySet(this);
			}
		}

		public AnimFeature_IconicItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
