using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationOption : IScriptable
	{
		private CHandle<gameuiCharacterCustomizationInfo> _info;
		private CEnum<gameuiCharacterCustomizationPart> _bodyPart;
		private CUInt32 _prevIndex;
		private CUInt32 _currIndex;
		private CBool _isActive;
		private CBool _isCensored;

		[Ordinal(0)] 
		[RED("info")] 
		public CHandle<gameuiCharacterCustomizationInfo> Info
		{
			get
			{
				if (_info == null)
				{
					_info = (CHandle<gameuiCharacterCustomizationInfo>) CR2WTypeManager.Create("handle:gameuiCharacterCustomizationInfo", "info", cr2w, this);
				}
				return _info;
			}
			set
			{
				if (_info == value)
				{
					return;
				}
				_info = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CEnum<gameuiCharacterCustomizationPart> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<gameuiCharacterCustomizationPart>) CR2WTypeManager.Create("gameuiCharacterCustomizationPart", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prevIndex")] 
		public CUInt32 PrevIndex
		{
			get
			{
				if (_prevIndex == null)
				{
					_prevIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "prevIndex", cr2w, this);
				}
				return _prevIndex;
			}
			set
			{
				if (_prevIndex == value)
				{
					return;
				}
				_prevIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currIndex")] 
		public CUInt32 CurrIndex
		{
			get
			{
				if (_currIndex == null)
				{
					_currIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "currIndex", cr2w, this);
				}
				return _currIndex;
			}
			set
			{
				if (_currIndex == value)
				{
					return;
				}
				_currIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get
			{
				if (_isCensored == null)
				{
					_isCensored = (CBool) CR2WTypeManager.Create("Bool", "isCensored", cr2w, this);
				}
				return _isCensored;
			}
			set
			{
				if (_isCensored == value)
				{
					return;
				}
				_isCensored = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
